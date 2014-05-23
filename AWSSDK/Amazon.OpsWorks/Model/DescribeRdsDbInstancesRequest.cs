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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRdsDbInstances operation.
    /// Describes Amazon RDS instances.
    /// </summary>
    public partial class DescribeRdsDbInstancesRequest : AmazonWebServiceRequest
    {
        private List<string> _rdsDbInstanceArns = new List<string>();
        private string _stackId;


        /// <summary>
        /// Gets and sets the property RdsDbInstanceArns. 
        /// <para>
        /// An array containing the ARNs of the instances to be described.
        /// </para>
        /// </summary>
        public List<string> RdsDbInstanceArns
        {
            get { return this._rdsDbInstanceArns; }
            set { this._rdsDbInstanceArns = value; }
        }

        /// <summary>
        /// Sets the RdsDbInstanceArns property
        /// </summary>
        /// <param name="rdsDbInstanceArns">The values to add to the RdsDbInstanceArns collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRdsDbInstancesRequest WithRdsDbInstanceArns(params string[] rdsDbInstanceArns)
        {
            foreach (var element in rdsDbInstanceArns)
            {
                this._rdsDbInstanceArns.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the RdsDbInstanceArns property
        /// </summary>
        /// <param name="rdsDbInstanceArns">The values to add to the RdsDbInstanceArns collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRdsDbInstancesRequest WithRdsDbInstanceArns(IEnumerable<string> rdsDbInstanceArns)
        {
            foreach (var element in rdsDbInstanceArns)
            {
                this._rdsDbInstanceArns.Add(element);
            }
            return this;
        }
        // Check to see if RdsDbInstanceArns property is set
        internal bool IsSetRdsDbInstanceArns()
        {
            return this._rdsDbInstanceArns != null && this._rdsDbInstanceArns.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID that the instances are registered with. The operation returns descriptions
        /// of all registered Amazon RDS instances.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeRdsDbInstancesRequest WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}