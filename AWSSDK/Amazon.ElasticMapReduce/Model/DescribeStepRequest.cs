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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStep operation.
    /// Provides more detail about the cluster step.
    /// </summary>
    public partial class DescribeStepRequest : AmazonWebServiceRequest
    {
        private string _clusterId;
        private string _stepId;


        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster with steps to describe.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }


        /// <summary>
        /// Sets the ClusterId property
        /// </summary>
        /// <param name="clusterId">The value to set for the ClusterId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStepRequest WithClusterId(string clusterId)
        {
            this._clusterId = clusterId;
            return this;
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }


        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        /// The identifier of the step to describe.
        /// </para>
        /// </summary>
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }


        /// <summary>
        /// Sets the StepId property
        /// </summary>
        /// <param name="stepId">The value to set for the StepId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStepRequest WithStepId(string stepId)
        {
            this._stepId = stepId;
            return this;
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

    }
}