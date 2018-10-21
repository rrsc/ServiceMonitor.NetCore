﻿using System;
using Microsoft.Extensions.Logging;
using ServiceMonitor.Core.BusinessLayer.Responses;

namespace ServiceMonitor.Core.BusinessLayer
{
    public static class ResponseExtensions
    {
        public static void SetError(this IResponse response, ILogger logger, string methodName, Exception ex)
        {
            response.DidError = true;
            response.ErrorMessage = ex.Message;

            logger?.LogCritical("Error on '{0}': {1}", methodName, ex);
        }
    }
}