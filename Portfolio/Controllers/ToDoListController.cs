﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

namespace Portfolio.Controllers
{
	public class ToDoListController : Controller
	{	PortfolioContext context=new PortfolioContext();
		public IActionResult ToDoListIndex()
		{
			var value= context.ToDoLists.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			context.ToDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("ToDoListIndex");

		}
		public IActionResult DeleteToDoList(int id)
		{
			var value = context.ToDoLists.Find(id);
			context.ToDoLists.Remove(value);
			return RedirectToAction("ToDoListIndex");
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value=context.ToDoLists.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList todoList)
		{
			context.ToDoLists.Update(todoList);
			context.SaveChanges();
			return RedirectToAction("ToDoListIndex");
		}
	}
}