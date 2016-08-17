using System;
using System.Net;

using Amazon.Runtime.Internal.Auth;
using Amazon.Util;


namespace Amazon.Runtime
{
    /// <summary>
    /// This interface is the read only access to the ClientConfig object used when setting up service clients. Once service clients
    /// are initiated the config object should not be changed to avoid issues with using a service client in a multi threaded environment.
    /// </summary>
    public partial interface IClientConfig
    {
        /// <summary>
        /// Gets the RegionEndpoint property. The region constant to use that 
        /// determines the endpoint to use.  If this is not set
        /// then the client will fallback to the value of ServiceURL.
        /// </summary>
        RegionEndpoint RegionEndpoint { get; }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        string RegionEndpointServiceName { get; }

        /// <summary>
        /// Gets and sets of the ServiceURL property.
        /// This is an optional property if you need to set a specific service URL 
        /// instead setting the region with the RegionEndpoint property.
        /// </summary>
        string ServiceURL { get; }

        /// <summary>
        /// Gets the UseHttp property.
        /// If this property is set to true, the client attempts
        /// to use HTTP protocol.
        /// By default, this property is set to false.
        /// </summary>
        bool UseHttp { get; }


        /// <summary>
        /// Gets Service Version
        /// </summary>
        string ServiceVersion { get; }

        /// <summary>
        /// Gets the signatureMethod property.
        /// </summary>
        SigningAlgorithm SignatureMethod { get; }

        /// <summary>
        /// Gets the SignatureVersion property.
        /// </summary>
        string SignatureVersion { get; }

        /// <summary>
        /// Gets the AuthenticationRegion property.
        /// Used in AWS4 request signing, this is an optional property; 
        /// change it only if the region cannot be determined from the 
        /// service endpoint.
        /// </summary>
        string AuthenticationRegion { get; }

        /// <summary>
        /// Gets the AuthenticationServiceName property.
        /// Used in AWS4 request signing, this is the short-form
        /// name of the service being called.
        /// </summary>
        string AuthenticationServiceName { get; }


        /// <summary>
        /// Gets the UserAgent property.
        /// </summary>
        string UserAgent { get; }


        /// <summary>
        /// Gets the DisableLogging. If true logging for this client will be disabled.
        /// </summary>
        bool DisableLogging { get; }

        /// <summary>
        /// Flag on whether to log metrics for service calls.
        /// 
        /// This can be set in the application's configs, as below:
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSLogMetrics" value"true"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        bool LogMetrics { get; }

        /// <summary>
        /// Gets the LogResponse property.
        /// If this property is set to true, the service response
        /// is read in its entirety and logged.
        /// </summary>
        bool LogResponse { get; }

        /// <summary>
        /// Gets the ReadEntireResponse.
        /// If this property is set to true, the service response
        /// is read in its entirety before being processed.
        /// </summary>
        bool ReadEntireResponse { get; }


        /// <summary>
        /// This flag controls if .NET HTTP infrastructure should follow redirection
        ///  responses (e.g. HTTP 307 - temporary redirect).
        /// </summary>
        bool AllowAutoRedirect { get; }

        /// <summary>
        /// Gets the BufferSize property.
        /// The BufferSize controls the buffer used to read in from input streams and write 
        /// out to the request.
        /// </summary>
        int BufferSize { get; }

        /// <summary>
        /// Gets the MaxErrorRetry property.
        /// </summary>
        int MaxErrorRetry { get; }

        /// <summary>
        /// Gets the interval at which progress update events are raised
        /// for upload operations. By default, the progress update events are 
        /// raised at every 100KB of data transferred. 
        /// </summary>
        long ProgressUpdateInterval { get; }

        /// <summary>
        /// Flag on whether to resign requests on retry or not.
        /// </summary>
        bool ResignRetries { get; }


        /// <summary>
        /// Credentials to use with a proxy.
        /// </summary>
        ICredentials ProxyCredentials { get; }

        /// <summary>
        /// Gets the default request timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the Timeout property of the HTTPWebRequest/HttpClient object used
        /// to send requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        TimeSpan? Timeout { get; }

        /// <summary>
        /// Configures the endpoint calculation for a service to go to a dual stack (ipv6 enabled) endpoint
        /// for the configured region.
        /// </summary>
        /// <remarks>
        /// Note: AWS services are enabling dualstack endpoints over time. It is your responsibility to check 
        /// that the service actually supports a dualstack endpoint in the configured region before enabling 
        /// this option for a service.
        /// </remarks>
        bool UseDualstackEndpoint { get; }


        /// <summary>
        /// Using either the RegionEndpoint or the ServiceURL determine what the URL to the service is.
        /// </summary>
        /// <returns>The URL to the service.</returns>
        string DetermineServiceURL();

        /// <summary>
        /// Performs validation on this config object.
        /// Throws exception if any of the required values are missing/invalid.
        /// </summary>
        /// <exception cref="Amazon.Runtime.AmazonClientException">The timeout specified is null.</exception>
        void Validate();


    }
}