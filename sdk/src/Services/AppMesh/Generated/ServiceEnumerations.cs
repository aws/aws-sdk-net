/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppMesh
{

    /// <summary>
    /// Constants used for properties of type DefaultGatewayRouteRewrite.
    /// </summary>
    public class DefaultGatewayRouteRewrite : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DefaultGatewayRouteRewrite
        /// </summary>
        public static readonly DefaultGatewayRouteRewrite DISABLED = new DefaultGatewayRouteRewrite("DISABLED");
        /// <summary>
        /// Constant ENABLED for DefaultGatewayRouteRewrite
        /// </summary>
        public static readonly DefaultGatewayRouteRewrite ENABLED = new DefaultGatewayRouteRewrite("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultGatewayRouteRewrite(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultGatewayRouteRewrite FindValue(string value)
        {
            return FindValue<DefaultGatewayRouteRewrite>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultGatewayRouteRewrite(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsResponseType.
    /// </summary>
    public class DnsResponseType : ConstantClass
    {

        /// <summary>
        /// Constant ENDPOINTS for DnsResponseType
        /// </summary>
        public static readonly DnsResponseType ENDPOINTS = new DnsResponseType("ENDPOINTS");
        /// <summary>
        /// Constant LOADBALANCER for DnsResponseType
        /// </summary>
        public static readonly DnsResponseType LOADBALANCER = new DnsResponseType("LOADBALANCER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsResponseType FindValue(string value)
        {
            return FindValue<DnsResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsResponseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DurationUnit.
    /// </summary>
    public class DurationUnit : ConstantClass
    {

        /// <summary>
        /// Constant Ms for DurationUnit
        /// </summary>
        public static readonly DurationUnit Ms = new DurationUnit("ms");
        /// <summary>
        /// Constant S for DurationUnit
        /// </summary>
        public static readonly DurationUnit S = new DurationUnit("s");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DurationUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DurationUnit FindValue(string value)
        {
            return FindValue<DurationUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DurationUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EgressFilterType.
    /// </summary>
    public class EgressFilterType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_ALL for EgressFilterType
        /// </summary>
        public static readonly EgressFilterType ALLOW_ALL = new EgressFilterType("ALLOW_ALL");
        /// <summary>
        /// Constant DROP_ALL for EgressFilterType
        /// </summary>
        public static readonly EgressFilterType DROP_ALL = new EgressFilterType("DROP_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EgressFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EgressFilterType FindValue(string value)
        {
            return FindValue<EgressFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EgressFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayRouteStatusCode.
    /// </summary>
    public class GatewayRouteStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GatewayRouteStatusCode
        /// </summary>
        public static readonly GatewayRouteStatusCode ACTIVE = new GatewayRouteStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for GatewayRouteStatusCode
        /// </summary>
        public static readonly GatewayRouteStatusCode DELETED = new GatewayRouteStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for GatewayRouteStatusCode
        /// </summary>
        public static readonly GatewayRouteStatusCode INACTIVE = new GatewayRouteStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayRouteStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayRouteStatusCode FindValue(string value)
        {
            return FindValue<GatewayRouteStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayRouteStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GrpcRetryPolicyEvent.
    /// </summary>
    public class GrpcRetryPolicyEvent : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for GrpcRetryPolicyEvent
        /// </summary>
        public static readonly GrpcRetryPolicyEvent Cancelled = new GrpcRetryPolicyEvent("cancelled");
        /// <summary>
        /// Constant DeadlineExceeded for GrpcRetryPolicyEvent
        /// </summary>
        public static readonly GrpcRetryPolicyEvent DeadlineExceeded = new GrpcRetryPolicyEvent("deadline-exceeded");
        /// <summary>
        /// Constant Internal for GrpcRetryPolicyEvent
        /// </summary>
        public static readonly GrpcRetryPolicyEvent Internal = new GrpcRetryPolicyEvent("internal");
        /// <summary>
        /// Constant ResourceExhausted for GrpcRetryPolicyEvent
        /// </summary>
        public static readonly GrpcRetryPolicyEvent ResourceExhausted = new GrpcRetryPolicyEvent("resource-exhausted");
        /// <summary>
        /// Constant Unavailable for GrpcRetryPolicyEvent
        /// </summary>
        public static readonly GrpcRetryPolicyEvent Unavailable = new GrpcRetryPolicyEvent("unavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GrpcRetryPolicyEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GrpcRetryPolicyEvent FindValue(string value)
        {
            return FindValue<GrpcRetryPolicyEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GrpcRetryPolicyEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpMethod.
    /// </summary>
    public class HttpMethod : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT for HttpMethod
        /// </summary>
        public static readonly HttpMethod CONNECT = new HttpMethod("CONNECT");
        /// <summary>
        /// Constant DELETE for HttpMethod
        /// </summary>
        public static readonly HttpMethod DELETE = new HttpMethod("DELETE");
        /// <summary>
        /// Constant GET for HttpMethod
        /// </summary>
        public static readonly HttpMethod GET = new HttpMethod("GET");
        /// <summary>
        /// Constant HEAD for HttpMethod
        /// </summary>
        public static readonly HttpMethod HEAD = new HttpMethod("HEAD");
        /// <summary>
        /// Constant OPTIONS for HttpMethod
        /// </summary>
        public static readonly HttpMethod OPTIONS = new HttpMethod("OPTIONS");
        /// <summary>
        /// Constant PATCH for HttpMethod
        /// </summary>
        public static readonly HttpMethod PATCH = new HttpMethod("PATCH");
        /// <summary>
        /// Constant POST for HttpMethod
        /// </summary>
        public static readonly HttpMethod POST = new HttpMethod("POST");
        /// <summary>
        /// Constant PUT for HttpMethod
        /// </summary>
        public static readonly HttpMethod PUT = new HttpMethod("PUT");
        /// <summary>
        /// Constant TRACE for HttpMethod
        /// </summary>
        public static readonly HttpMethod TRACE = new HttpMethod("TRACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpMethod FindValue(string value)
        {
            return FindValue<HttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpScheme.
    /// </summary>
    public class HttpScheme : ConstantClass
    {

        /// <summary>
        /// Constant Http for HttpScheme
        /// </summary>
        public static readonly HttpScheme Http = new HttpScheme("http");
        /// <summary>
        /// Constant Https for HttpScheme
        /// </summary>
        public static readonly HttpScheme Https = new HttpScheme("https");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpScheme FindValue(string value)
        {
            return FindValue<HttpScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpScheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpPreference.
    /// </summary>
    public class IpPreference : ConstantClass
    {

        /// <summary>
        /// Constant IPv4_ONLY for IpPreference
        /// </summary>
        public static readonly IpPreference IPv4_ONLY = new IpPreference("IPv4_ONLY");
        /// <summary>
        /// Constant IPv4_PREFERRED for IpPreference
        /// </summary>
        public static readonly IpPreference IPv4_PREFERRED = new IpPreference("IPv4_PREFERRED");
        /// <summary>
        /// Constant IPv6_ONLY for IpPreference
        /// </summary>
        public static readonly IpPreference IPv6_ONLY = new IpPreference("IPv6_ONLY");
        /// <summary>
        /// Constant IPv6_PREFERRED for IpPreference
        /// </summary>
        public static readonly IpPreference IPv6_PREFERRED = new IpPreference("IPv6_PREFERRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpPreference FindValue(string value)
        {
            return FindValue<IpPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListenerTlsMode.
    /// </summary>
    public class ListenerTlsMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ListenerTlsMode
        /// </summary>
        public static readonly ListenerTlsMode DISABLED = new ListenerTlsMode("DISABLED");
        /// <summary>
        /// Constant PERMISSIVE for ListenerTlsMode
        /// </summary>
        public static readonly ListenerTlsMode PERMISSIVE = new ListenerTlsMode("PERMISSIVE");
        /// <summary>
        /// Constant STRICT for ListenerTlsMode
        /// </summary>
        public static readonly ListenerTlsMode STRICT = new ListenerTlsMode("STRICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListenerTlsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListenerTlsMode FindValue(string value)
        {
            return FindValue<ListenerTlsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListenerTlsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MeshStatusCode.
    /// </summary>
    public class MeshStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MeshStatusCode
        /// </summary>
        public static readonly MeshStatusCode ACTIVE = new MeshStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for MeshStatusCode
        /// </summary>
        public static readonly MeshStatusCode DELETED = new MeshStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for MeshStatusCode
        /// </summary>
        public static readonly MeshStatusCode INACTIVE = new MeshStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MeshStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MeshStatusCode FindValue(string value)
        {
            return FindValue<MeshStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MeshStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortProtocol.
    /// </summary>
    public class PortProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Grpc for PortProtocol
        /// </summary>
        public static readonly PortProtocol Grpc = new PortProtocol("grpc");
        /// <summary>
        /// Constant Http for PortProtocol
        /// </summary>
        public static readonly PortProtocol Http = new PortProtocol("http");
        /// <summary>
        /// Constant Http2 for PortProtocol
        /// </summary>
        public static readonly PortProtocol Http2 = new PortProtocol("http2");
        /// <summary>
        /// Constant Tcp for PortProtocol
        /// </summary>
        public static readonly PortProtocol Tcp = new PortProtocol("tcp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortProtocol FindValue(string value)
        {
            return FindValue<PortProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteStatusCode.
    /// </summary>
    public class RouteStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RouteStatusCode
        /// </summary>
        public static readonly RouteStatusCode ACTIVE = new RouteStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for RouteStatusCode
        /// </summary>
        public static readonly RouteStatusCode DELETED = new RouteStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for RouteStatusCode
        /// </summary>
        public static readonly RouteStatusCode INACTIVE = new RouteStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteStatusCode FindValue(string value)
        {
            return FindValue<RouteStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TcpRetryPolicyEvent.
    /// </summary>
    public class TcpRetryPolicyEvent : ConstantClass
    {

        /// <summary>
        /// Constant ConnectionError for TcpRetryPolicyEvent
        /// </summary>
        public static readonly TcpRetryPolicyEvent ConnectionError = new TcpRetryPolicyEvent("connection-error");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TcpRetryPolicyEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TcpRetryPolicyEvent FindValue(string value)
        {
            return FindValue<TcpRetryPolicyEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TcpRetryPolicyEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualGatewayListenerTlsMode.
    /// </summary>
    public class VirtualGatewayListenerTlsMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for VirtualGatewayListenerTlsMode
        /// </summary>
        public static readonly VirtualGatewayListenerTlsMode DISABLED = new VirtualGatewayListenerTlsMode("DISABLED");
        /// <summary>
        /// Constant PERMISSIVE for VirtualGatewayListenerTlsMode
        /// </summary>
        public static readonly VirtualGatewayListenerTlsMode PERMISSIVE = new VirtualGatewayListenerTlsMode("PERMISSIVE");
        /// <summary>
        /// Constant STRICT for VirtualGatewayListenerTlsMode
        /// </summary>
        public static readonly VirtualGatewayListenerTlsMode STRICT = new VirtualGatewayListenerTlsMode("STRICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualGatewayListenerTlsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualGatewayListenerTlsMode FindValue(string value)
        {
            return FindValue<VirtualGatewayListenerTlsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualGatewayListenerTlsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualGatewayPortProtocol.
    /// </summary>
    public class VirtualGatewayPortProtocol : ConstantClass
    {

        /// <summary>
        /// Constant Grpc for VirtualGatewayPortProtocol
        /// </summary>
        public static readonly VirtualGatewayPortProtocol Grpc = new VirtualGatewayPortProtocol("grpc");
        /// <summary>
        /// Constant Http for VirtualGatewayPortProtocol
        /// </summary>
        public static readonly VirtualGatewayPortProtocol Http = new VirtualGatewayPortProtocol("http");
        /// <summary>
        /// Constant Http2 for VirtualGatewayPortProtocol
        /// </summary>
        public static readonly VirtualGatewayPortProtocol Http2 = new VirtualGatewayPortProtocol("http2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualGatewayPortProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualGatewayPortProtocol FindValue(string value)
        {
            return FindValue<VirtualGatewayPortProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualGatewayPortProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualGatewayStatusCode.
    /// </summary>
    public class VirtualGatewayStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VirtualGatewayStatusCode
        /// </summary>
        public static readonly VirtualGatewayStatusCode ACTIVE = new VirtualGatewayStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for VirtualGatewayStatusCode
        /// </summary>
        public static readonly VirtualGatewayStatusCode DELETED = new VirtualGatewayStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for VirtualGatewayStatusCode
        /// </summary>
        public static readonly VirtualGatewayStatusCode INACTIVE = new VirtualGatewayStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualGatewayStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualGatewayStatusCode FindValue(string value)
        {
            return FindValue<VirtualGatewayStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualGatewayStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualNodeStatusCode.
    /// </summary>
    public class VirtualNodeStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VirtualNodeStatusCode
        /// </summary>
        public static readonly VirtualNodeStatusCode ACTIVE = new VirtualNodeStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for VirtualNodeStatusCode
        /// </summary>
        public static readonly VirtualNodeStatusCode DELETED = new VirtualNodeStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for VirtualNodeStatusCode
        /// </summary>
        public static readonly VirtualNodeStatusCode INACTIVE = new VirtualNodeStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualNodeStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualNodeStatusCode FindValue(string value)
        {
            return FindValue<VirtualNodeStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualNodeStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualRouterStatusCode.
    /// </summary>
    public class VirtualRouterStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VirtualRouterStatusCode
        /// </summary>
        public static readonly VirtualRouterStatusCode ACTIVE = new VirtualRouterStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for VirtualRouterStatusCode
        /// </summary>
        public static readonly VirtualRouterStatusCode DELETED = new VirtualRouterStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for VirtualRouterStatusCode
        /// </summary>
        public static readonly VirtualRouterStatusCode INACTIVE = new VirtualRouterStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualRouterStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualRouterStatusCode FindValue(string value)
        {
            return FindValue<VirtualRouterStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualRouterStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualServiceStatusCode.
    /// </summary>
    public class VirtualServiceStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VirtualServiceStatusCode
        /// </summary>
        public static readonly VirtualServiceStatusCode ACTIVE = new VirtualServiceStatusCode("ACTIVE");
        /// <summary>
        /// Constant DELETED for VirtualServiceStatusCode
        /// </summary>
        public static readonly VirtualServiceStatusCode DELETED = new VirtualServiceStatusCode("DELETED");
        /// <summary>
        /// Constant INACTIVE for VirtualServiceStatusCode
        /// </summary>
        public static readonly VirtualServiceStatusCode INACTIVE = new VirtualServiceStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualServiceStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualServiceStatusCode FindValue(string value)
        {
            return FindValue<VirtualServiceStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualServiceStatusCode(string value)
        {
            return FindValue(value);
        }
    }

}