using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryDal
{
    public class DalTask
    {
        private readonly AppDbContext _context;

        public DalTask(AppDbContext context)
        {
            _context = context;
        }

        public void AddTask(TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int taskId)
        {
            var task = _context.Tasks.Find(taskId);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public void UpdateTask(TaskModel updatedTask)
        {
            var task = _context.Tasks.Find(updatedTask.TaskManagmentID);
            if (task != null)
            {
                task.TaskName = updatedTask.TaskName;
                task.TaskDescription = updatedTask.TaskDescription;
                task.DueDate = updatedTask.DueDate;
                task.TaskPriority = updatedTask.TaskPriority;
                task.SpecialNote = updatedTask.SpecialNote;
                task.TaskStatus = updatedTask.TaskStatus;

                _context.SaveChanges();
            }
        }

        public List<TaskModel> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public TaskModel GetTaskById(int taskId)
        {
            return _context.Tasks.FirstOrDefault(t => t.TaskManagmentID == taskId);
        }

        public void CompleteTask(int taskId)
        {
            var task = _context.Tasks.Find(taskId);
            if (task != null)
            {
                task.TaskStatus = "Completed"; // Assuming "Completed" is the status value
                _context.SaveChanges();
            }
        }
    }
}
