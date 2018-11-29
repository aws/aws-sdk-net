/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppMesh
{

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
        /// Constant Http for PortProtocol
        /// </summary>
        public static readonly PortProtocol Http = new PortProtocol("http");
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

}