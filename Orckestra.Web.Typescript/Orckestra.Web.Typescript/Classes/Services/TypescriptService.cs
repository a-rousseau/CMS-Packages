﻿using System.Text;

namespace Orckestra.Web.Typescript.Classes.Services
{
    public abstract class TypescriptService
    {
        protected bool _configured, _invoked;

        public bool IsConfigured() => _configured;
        public bool IsInvoked() => _invoked;

        public string ComposeExceptionInfo(string methodName, string taskName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Service: {GetType().Name}.");
            sb.AppendLine($"Method: {methodName}.");
            if (!string.IsNullOrEmpty(taskName))
            {
                sb.AppendLine($"Task: {taskName}.");
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}