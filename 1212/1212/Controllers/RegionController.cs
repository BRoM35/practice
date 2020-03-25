﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1212.Controllers
{
    [ApiController]
    [Route("region/{code}")]
    public class RegionController : ControllerBase
    {
        [HttpGet]
        public string Get(int code)
        {
            string[] regions = new string[] { "", "Республика Адыгея (Адыгея)", "Республика Башкортостан", "Республика Бурятия", "Республика Алтай", "Республика Дагестан", "Республика Ингушетия", "Кабардино-Балкарская Республика", "Республика Калмыкия","Карачаево-Черкесская Республика","Республика Карелия","Республика Коми","Республика Марий Эл", "Республика Мордовия","Республика Саха (Якутия)", "Республика Северная Осетия - Алания","Республика Татарстан (Татарстан)","Республика Тыва", "Удмуртская Республика", "Республика Хакасия","Чеченская Республика","Чувашская Республика - Чувашия","Алтайский край","Краснодарский край","Красноярский край", "Приморский край","Ставропольский край","Хабаровский край", "Амурская область","Архангельская область", "Астраханская область","Белгородская область","Брянская область","Владимирская область","Волгоградская область","Вологодская область","Воронежская область","Ивановская область","Иркутская область","Калининградская область","Калужская область","Камчатский край","Кемеровская область","Кировская область", "Костромская область","Курганская область","Курская область","Ленинградская область", "Липецкая область","Магаданская область","Московская область","Мурманская область","Нижегородская область","Новгородская область","Новосибирская область","Омская область","Оренбургская область","Орловская область","Пензенская область","Пермский край","Псковская область","Ростовская область","Рязанская область","Самарская область","Саратовская область","Сахалинская область","Свердловская область","Смоленская область","Тамбовская область","Тверская область","Томская область","Тульская область","Тюменская область","Ульяновская область","Челябинская область","Забайкальский край","Ярославская область","г. Москва","Санкт-Петербург","Еврейская автономная область","Ненецкий автономный округ","Ханты-Мансийский автономный округ - Югра","Чукотский автономный округ","Ямало-Ненецкий автономный округ","Иные территории, включая город и космодром Байконур" };

            return regions[code].ToString();
        }
    }
}