/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.Route53
{


    /// <summary>Change Action
    /// </summary>
    public class ChangeAction : ConstantClass
    {


       /// <summary>Constant CREATE for ChangeAction
       /// </summary>
        public static readonly ChangeAction CREATE = new ChangeAction("CREATE");
    

       /// <summary>Constant DELETE for ChangeAction
       /// </summary>
        public static readonly ChangeAction DELETE = new ChangeAction("DELETE");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Change Status
    /// </summary>
    public class ChangeStatus : ConstantClass
    {


       /// <summary>Constant INSYNC for ChangeStatus
       /// </summary>
        public static readonly ChangeStatus INSYNC = new ChangeStatus("INSYNC");
    

       /// <summary>Constant PENDING for ChangeStatus
       /// </summary>
        public static readonly ChangeStatus PENDING = new ChangeStatus("PENDING");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChangeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeStatus FindValue(string value)
        {
            return FindValue<ChangeStatus>(value);
        }

        public static implicit operator ChangeStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Health Check Type
    /// </summary>
    public class HealthCheckType : ConstantClass
    {


       /// <summary>Constant HTTP for HealthCheckType
       /// </summary>
        public static readonly HealthCheckType HTTP = new HealthCheckType("HTTP");
    

       /// <summary>Constant TCP for HealthCheckType
       /// </summary>
        public static readonly HealthCheckType TCP = new HealthCheckType("TCP");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public HealthCheckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckType FindValue(string value)
        {
            return FindValue<HealthCheckType>(value);
        }

        public static implicit operator HealthCheckType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>R R Type
    /// </summary>
    public class RRType : ConstantClass
    {


       /// <summary>Constant A for RRType
       /// </summary>
        public static readonly RRType A = new RRType("A");
    

       /// <summary>Constant AAAA for RRType
       /// </summary>
        public static readonly RRType AAAA = new RRType("AAAA");
    

       /// <summary>Constant CNAME for RRType
       /// </summary>
        public static readonly RRType CNAME = new RRType("CNAME");
    

       /// <summary>Constant MX for RRType
       /// </summary>
        public static readonly RRType MX = new RRType("MX");
    

       /// <summary>Constant NS for RRType
       /// </summary>
        public static readonly RRType NS = new RRType("NS");
    

       /// <summary>Constant PTR for RRType
       /// </summary>
        public static readonly RRType PTR = new RRType("PTR");
    

       /// <summary>Constant SOA for RRType
       /// </summary>
        public static readonly RRType SOA = new RRType("SOA");
    

       /// <summary>Constant SPF for RRType
       /// </summary>
        public static readonly RRType SPF = new RRType("SPF");
    

       /// <summary>Constant SRV for RRType
       /// </summary>
        public static readonly RRType SRV = new RRType("SRV");
    

       /// <summary>Constant TXT for RRType
       /// </summary>
        public static readonly RRType TXT = new RRType("TXT");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RRType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RRType FindValue(string value)
        {
            return FindValue<RRType>(value);
        }

        public static implicit operator RRType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Resource Record Set Failover
    /// </summary>
    public class ResourceRecordSetFailover : ConstantClass
    {


       /// <summary>Constant PRIMARY for ResourceRecordSetFailover
       /// </summary>
        public static readonly ResourceRecordSetFailover PRIMARY = new ResourceRecordSetFailover("PRIMARY");
    

       /// <summary>Constant SECONDARY for ResourceRecordSetFailover
       /// </summary>
        public static readonly ResourceRecordSetFailover SECONDARY = new ResourceRecordSetFailover("SECONDARY");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ResourceRecordSetFailover(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceRecordSetFailover FindValue(string value)
        {
            return FindValue<ResourceRecordSetFailover>(value);
        }

        public static implicit operator ResourceRecordSetFailover(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Resource Record Set Region
    /// </summary>
    public class ResourceRecordSetRegion : ConstantClass
    {


       /// <summary>Constant ApNortheast1 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion ApNortheast1 = new ResourceRecordSetRegion("ap-northeast-1");
    

       /// <summary>Constant ApSoutheast1 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion ApSoutheast1 = new ResourceRecordSetRegion("ap-southeast-1");
    

       /// <summary>Constant ApSoutheast2 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion ApSoutheast2 = new ResourceRecordSetRegion("ap-southeast-2");
    

       /// <summary>Constant EuWest1 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion EuWest1 = new ResourceRecordSetRegion("eu-west-1");
    

       /// <summary>Constant SaEast1 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion SaEast1 = new ResourceRecordSetRegion("sa-east-1");
    

       /// <summary>Constant UsEast1 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion UsEast1 = new ResourceRecordSetRegion("us-east-1");
    

       /// <summary>Constant UsWest1 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion UsWest1 = new ResourceRecordSetRegion("us-west-1");
    

       /// <summary>Constant UsWest2 for ResourceRecordSetRegion
       /// </summary>
        public static readonly ResourceRecordSetRegion UsWest2 = new ResourceRecordSetRegion("us-west-2");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ResourceRecordSetRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceRecordSetRegion FindValue(string value)
        {
            return FindValue<ResourceRecordSetRegion>(value);
        }

        public static implicit operator ResourceRecordSetRegion(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
