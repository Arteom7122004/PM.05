//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPM._05
{
    using System;
    using System.Collections.Generic;
    
    public partial class Работник
    {
        public int Id { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Пол { get; set; }
        public System.DateTime Дата_рождения { get; set; }
        public string Телефон { get; set; }
        public string Адрес { get; set; }
        public string Образование { get; set; }
        public string Должность { get; set; }
    
        public virtual График_работы График_работы { get; set; }
    }
}
