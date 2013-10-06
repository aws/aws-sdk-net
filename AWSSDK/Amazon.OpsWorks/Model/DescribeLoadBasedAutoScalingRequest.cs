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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLoadBasedAutoScaling operation.
    /// <para>Describes load-based auto scaling configurations for specified layers.</para> <para><b>NOTE:</b>You must specify at least one of the
    /// parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeLoadBasedAutoScaling"/>
    public class DescribeLoadBasedAutoScalingRequest : AmazonWebServiceRequest
    {
        private List<string> layerIds = new List<string>();

        /// <summary>
        /// An array of layer IDs.
        ///  
        /// </summary>
        public List<string> LayerIds
        {
            get { return this.layerIds; }
            set { this.layerIds = value; }
        }
        /// <summary>
        /// Adds elements to the LayerIds collection
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBasedAutoScalingRequest WithLayerIds(params string[] layerIds)
        {
            foreach (string element in layerIds)
            {
                this.layerIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the LayerIds collection
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeLoadBasedAutoScalingRequest WithLayerIds(IEnumerable<string> layerIds)
        {
            foreach (string element in layerIds)
            {
                this.layerIds.Add(element);
            }

            return this;
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this.layerIds.Count > 0;
        }
    }
}
    
