using System;
using System.Collections.Generic;
using System.ComponentModel;//Eklendi..
using System.Data;//Eklendi..
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SinemaOtomasyonu
{
    class PrintYardım
    {
        public DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();//Tablo tipinde bir liste create et diyoruz. T liste demek burada..
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (T item in list)// listedeki bilgileri t tablosuna item adıyla atıyoruz..
            {
                DataRow row = table.NewRow();//Sanal tablo oluşturduk..
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;//Eğer veri gelmezse DBNull ata hataya düşmeyi engelliyor..
                }
                table.Rows.Add(row);//tablonun içindeki bilgileri row a taşı..
            }
            return table;
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            return table;
        }
    }
}
