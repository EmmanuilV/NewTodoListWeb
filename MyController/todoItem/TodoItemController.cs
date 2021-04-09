using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//using Controller.Models;

namespace TodoItems.Controllers
{

    [Route("api/todolists")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {

        private TodoListService todoListService;


        public TodoItemController(TodoListService service1)
        {
            this.todoListService = service1;
        }

        [HttpGet("{listId}/tasks/getall")]
        public ActionResult<List<TodoItem>> GetTodoItems(int listId)
        {
            return Ok(todoListService.ReadAllTodoItems(listId));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItemById(int id)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }

        [HttpPost("{listId}/tasks/createitem")]
        public void CreateTodoItem(int listId, TodoItem todoItem)
        {

            todoListService.AddTodoItem(listId, todoItem);

            //return Created($"api/todolist/create/{createdItem.Id}", createdItem);
            //return todoListService.AddTodoItem(todoItem);
        }
        [HttpPost("createlist")]
        public void CreateTodoList(TodoList todoList)
        {

            todoListService.AddTodoList(todoList);

            //return Created($"api/todolist/create/{createdItem.Id}", createdItem);
            //return todoListService.AddTodoItem(todoItem);
        }


        [HttpPut("{listId}/tasks/update/{itemId}")]
        public IActionResult PutTodoItem(int listId, int itemId, TodoItem model)
        {
            return Ok(todoListService.UpdateTodoItem(listId, itemId, model));
        }

        [HttpDelete("delete/{id}")]
        public ActionResult<TodoItem> DeleteTodoItemById(int listId, int itemId)
        {
            return Ok(todoListService.DeleteTodoItem(listId, itemId));
        }
    }


}