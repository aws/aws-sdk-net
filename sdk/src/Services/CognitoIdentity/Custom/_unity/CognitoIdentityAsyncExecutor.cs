using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.CognitoIdentity
{
    internal class CognitoIdentityAsyncExecutor
    {

        private static Logger Logger = Logger.GetLogger(typeof(CognitoIdentityAsyncExecutor));


        public static void ExecuteAsync<T>(Func<T> function, AsyncOptions options, AmazonCognitoIdentityCallback<T> callback)
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                T result = default(T);
                Exception exception = null;
                try
                {
                    result = function();
                }
                catch (Exception ex)
                {
                    exception = ex;
                }

                if (callback != null)
                {
                    if (options.ExecuteCallbackOnMainThread)
                    {
                        UnityRequestQueue.Instance.ExecuteOnMainThread(() =>
                        {
                            callback(new AmazonCognitoIdentityResult<T>(result, exception, options.State));
                        });
                    }
                    else
                    {
                        try
                        {
                            callback(new AmazonCognitoIdentityResult<T>(result, exception, options.State));
                        }
                        catch (Exception callbackException)
                        {
                            // Catch any unhandled exceptions from the user callback 
                            // and log it. 
                            Logger.Error(callbackException,
                                "An unhandled exception was thrown from the callback method {0}.",
                                callback.Method.Name);
                        }
                    }
                }
            });
        }
    }
}
