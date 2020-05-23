using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStoreBookTutor.Models;

namespace SportStoreBookTutor.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository; // Создаем ?экземпляр интерфейса?

        public ProductController(IProductRepository repo) //Конструктор в качестве параметров которого ??данные? из IProductRepository?
        {
            repository = repo;
        }
        /// <summary>
       // Инфраструктура MVC создаст экземпляр класса FakeRepository.после чего будет использовать его для создания нового объекта контроллера, обрабатывающего запрос.
        //Фиктивное хранилище снабдит контроллер простыми тестовыми данными , которые его метод действия передаст представлению Razor, так что НТМL-ответ для
//браузера будет включать детали каждого объекта Product.При генерации НТМLответа инфраструктура MVC объединит данные из представления, выбранные методом
//действия, с содержимым разделяемой компоновки. порождая завершенный НТМL-документ, который браузер в состоянии разобрать и отобразить.Запустив приложение, можно увидеть результат,
        /// </summary>
        /// <returns></returns>
        public IActionResult List() => View(repository.Products); 
        //public IActionResult List()
        //{
        //   return View(repository.Products); -----> Это так же работает, просто верхняя выглядит пизже
        //}
        //В книге написано ViewResult, но можно так же использовать и IActionResult хз в чем разница //List() - это имя метода, а так же имя View (по стандартам мвс)
        /*Вызов метода View () подобного рода (без указания имени представления) сообщает инфраструктуре MVC о том, что нужно визуализировать стандартное представление
для метода действия. Передача методу View () коллекции объектов Product из хранилища снабжает инфраструктуру данными, которыми необходимо заполнить 
объект Model в строго типизированном представлении.*/
    }
}