using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Reflection;
using System.Net;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This class is used to wrap around <see cref="UnityEngine.Experimental.Networking.UnityWebRequest"/>
    /// so that we can be backward compatible with unity 4.6
    /// </summary>
    public class UnityWebRequestWrapper : IDisposable
    {
        private static Type unityWebRequestType;

        private static PropertyInfo[] unityWebRequestProperties;
        private static MethodInfo[] unityWebRequestMethods;

        //all methods
        private static MethodInfo setRequestHeaderMethod;
        private static MethodInfo sendMethod;
        private static MethodInfo getResponseHeadersMethod;
        private static MethodInfo isDoneGetMethod;
        private static MethodInfo downloadProgressGetMethod;
        private static MethodInfo uploadProgressGetMethod;
        private static MethodInfo isErrorGetMethod;
        private static MethodInfo downloadedBytesGetMethod;
        private static MethodInfo responseCodeGetMethod;
        private static MethodInfo downloadHandlerSetMethod;
        private static MethodInfo uploadHandlerSetMethod;
        private static MethodInfo errorGetMethod;

        // the instance of the unitywebrequest
        private object unityWebRequestInstance;


        private DownloadHandlerBufferWrapper downloadHandler;
        private UploadHandlerRawWrapper uploadHandler;

        static UnityWebRequestWrapper()
        {
            unityWebRequestType = Type.GetType("UnityEngine.Experimental.Networking.UnityWebRequest, UnityEngine");

            unityWebRequestMethods = unityWebRequestType.GetMethods();
            unityWebRequestProperties = unityWebRequestType.GetProperties();

            PropertyInfo isDoneProperty = unityWebRequestType.GetProperty("isDone");
            PropertyInfo downloadProgressProperty = unityWebRequestType.GetProperty("downloadProgress");
            PropertyInfo uploadProgressProperty = unityWebRequestType.GetProperty("uploadProgress");
            PropertyInfo isErrorProperty = unityWebRequestType.GetProperty("isError");
            PropertyInfo downloadedBytesProperty = unityWebRequestType.GetProperty("downloadedBytes");
            PropertyInfo responseCodeProperty = unityWebRequestType.GetProperty("responseCode");
            PropertyInfo downloadHandlerPropery = unityWebRequestType.GetProperty("downloadHandler");
            PropertyInfo uploadHandlerPropery = unityWebRequestType.GetProperty("uploadHandler");
            PropertyInfo errorProperty = unityWebRequestType.GetProperty("error");

            setRequestHeaderMethod = unityWebRequestType.GetMethod("SetRequestHeader");
            sendMethod = unityWebRequestType.GetMethod("Send");
            getResponseHeadersMethod = unityWebRequestType.GetMethod("GetResponseHeaders");

            isDoneGetMethod = isDoneProperty.GetGetMethod();
            isErrorGetMethod = isErrorProperty.GetGetMethod();
            uploadProgressGetMethod = uploadProgressProperty.GetGetMethod();
            downloadProgressGetMethod = downloadProgressProperty.GetGetMethod();
            downloadedBytesGetMethod = downloadedBytesProperty.GetGetMethod();
            responseCodeGetMethod = responseCodeProperty.GetGetMethod();
            downloadHandlerSetMethod = downloadHandlerPropery.GetSetMethod();
            uploadHandlerSetMethod = uploadHandlerPropery.GetSetMethod();
            errorGetMethod = errorProperty.GetGetMethod();
        }

        /// <summary>
        /// Create an instance of UnityWebRequestWrapper
        /// </summary>
        public UnityWebRequestWrapper()
        {
            if (!AWSConfigs.UnityWebRequestInitialized)
                throw new InvalidOperationException("UnityWebRequest is not supported in the current version of unity");

            unityWebRequestInstance = Activator.CreateInstance(unityWebRequestType);
        }

        /// <summary>
        /// Create an instance of UnityWebRequestWrapper
        /// </summary>
        /// <param name="url">Url of the request</param>
        /// <param name="method">The HTTP Methods</param>
        public UnityWebRequestWrapper(string url, string method)
        {
            unityWebRequestInstance = Activator.CreateInstance(unityWebRequestType, url, method);
        }

        /// <summary>
        /// Create an instance of UnityWebRequestWrapper
        /// </summary>
        /// <param name="url">Url of the request</param>
        /// <param name="method">The HTTP Methods</param>
        /// <param name="downloadHandler">Instance of <see cref="DownloadHandlerBufferWrapper"/></param>
        /// <param name="uploadHandler">Instance of <see cref="UploadHandlerRawWrapper"/></param>
        public UnityWebRequestWrapper(string url, string method, DownloadHandlerBufferWrapper downloadHandler, UploadHandlerRawWrapper uploadHandler)
        {
            if (downloadHandler == null)
                throw new ArgumentNullException("downloadHandler");

            if (uploadHandler == null)
                throw new ArgumentNullException("uploadHandler");

            unityWebRequestInstance = Activator.CreateInstance(unityWebRequestType, url, method, downloadHandler.Instance, uploadHandler.Instance);
        }

        /// <summary>
        /// Get and Sets an instance of Download Handler
        /// </summary>
        public DownloadHandlerBufferWrapper DownloadHandler
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                downloadHandlerSetMethod.Invoke(unityWebRequestInstance, new object[] { value.Instance });
                this.downloadHandler = value;
            }
            get
            {
                return this.downloadHandler;
            }
        }

        /// <summary>
        /// Gets and Sets an instance of Upload Handler
        /// </summary>
        public UploadHandlerRawWrapper UploadHandler
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                uploadHandlerSetMethod.Invoke(unityWebRequestInstance, new object[] { value.Instance });
                this.uploadHandler = value;
            }
            get
            {
                return this.uploadHandler;
            }
        }

        /// <summary>
        /// Set the request Header
        /// </summary>
        /// <param name="key">the header key</param>
        /// <param name="value">the header value</param>
        public void SetRequestHeader(string key, string value)
        {
            setRequestHeaderMethod.Invoke(unityWebRequestInstance, new object[] { key, value });
        }


        /// <summary>
        /// Make the http call
        /// </summary>
        /// <returns></returns>
        public AsyncOperation Send()
        {
            return (AsyncOperation)sendMethod.Invoke(unityWebRequestInstance, null);
        }

        /// <summary>
        /// Boolean value indicating if the http operation is complete
        /// </summary>
        public bool IsDone
        {
            get
            {
                return (bool)isDoneGetMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        /// <summary>
        /// The download progress
        /// </summary>
        public float DownloadProgress
        {
            get
            {
                return (float)downloadProgressGetMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        /// <summary>
        /// The upload Progress
        /// </summary>
        public float UploadProgress
        {
            get
            {
                return (float)uploadProgressGetMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        /// <summary>
        /// Number of bytes downloaded
        /// </summary>
        public ulong DownloadedBytes
        {
            get
            {
                return (ulong)downloadedBytesGetMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        /// <summary>
        /// The response headers
        /// </summary>
        public Dictionary<string, string> ResponseHeaders
        {
            get
            {

                return (Dictionary<string, string>)getResponseHeadersMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        /// <summary>
        /// The http status code
        /// </summary>
        public HttpStatusCode? StatusCode
        {
            get
            {
                object responseCodeObject = responseCodeGetMethod.Invoke(unityWebRequestInstance, null);
                long responseCode = (long)responseCodeObject;
                if (responseCode == -1)
                    return null;

                return (HttpStatusCode)responseCode;
            }
        }

        /// <summary>
        /// returns if the http operation ended with an error
        /// </summary>
        public bool IsError
        {
            get
            {
                return (bool)isErrorGetMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        /// <summary>
        /// returns the error string in case the http operation ended with an error
        /// </summary>
        public string Error
        {
            get
            {
                return (string)errorGetMethod.Invoke(unityWebRequestInstance, null);
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    var disposableWebRequest = unityWebRequestInstance as IDisposable;
                    if (disposableWebRequest != null)
                        disposableWebRequest.Dispose();
                }

                unityWebRequestInstance = null;
                disposedValue = true;
            }
        }
        
        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }

    public class DownloadHandlerBufferWrapper : IDisposable
    {
        private static Type downloadHandlerBufferType;
        private static PropertyInfo[] downloadHandlerBufferProperties;
        private static MethodInfo[] downloadHandlerBufferMethods;

        private static PropertyInfo dataProperty;

        private static MethodInfo dataGetMethod;

        /// <summary>
        /// Instance of <see cref="UnityEngine.Experimental.Networking.DownloadHandlerBuffer"/>
        /// </summary>
        public object Instance { get; private set; }

        static DownloadHandlerBufferWrapper()
        {
            downloadHandlerBufferType = Type.GetType("UnityEngine.Experimental.Networking.DownloadHandlerBuffer, UnityEngine");
            downloadHandlerBufferMethods = downloadHandlerBufferType.GetMethods();
            downloadHandlerBufferProperties = downloadHandlerBufferType.GetProperties();

            dataProperty = downloadHandlerBufferType.GetProperty("data");

            dataGetMethod = dataProperty.GetGetMethod();
        }

        /// <summary>
        /// Creates an new instance of <see cref="DownloadHandlerBufferWrapper"/>
        /// </summary>
        public DownloadHandlerBufferWrapper()
        {
            Instance = Activator.CreateInstance(downloadHandlerBufferType);
        }

        /// <summary>
        /// Returns the response data as a array of bytes
        /// </summary>
        public byte[] Data
        {
            get
            {
                return (byte[])dataGetMethod.Invoke(Instance, null);
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    var disposableHandler = Instance as IDisposable;
                    if (disposableHandler != null)
                        disposableHandler.Dispose();
                }

                Instance = null;

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }

    public class UploadHandlerRawWrapper : IDisposable
    {
        private static Type uploadHandlerRawType;

        /// <summary>
        /// Instance of <see cref="UnityEngine.Experimental.Networking.UploadHandlerRaw"/>
        /// </summary>
        public object Instance { get; private set; }

        static UploadHandlerRawWrapper()
        {
            uploadHandlerRawType = Type.GetType("UnityEngine.Experimental.Networking.UploadHandlerRaw, UnityEngine");
        }

        /// <summary>
        /// Creates an instance of <see cref="UploadHandlerRawWrapper"/>
        /// </summary>
        /// <param name="data"></param>
        public UploadHandlerRawWrapper(byte[] data)
        {
            Instance = Activator.CreateInstance(uploadHandlerRawType, data);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    var disposableHandler = Instance as IDisposable;
                    if (disposableHandler != null)
                        disposableHandler.Dispose();
                }
                Instance = null;

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }
}
