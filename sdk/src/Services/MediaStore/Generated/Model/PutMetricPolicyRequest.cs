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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricPolicy operation.
    /// The metric policy that you want to add to the container. A metric policy allows AWS
    /// Elemental MediaStore to send metrics to Amazon CloudWatch. It takes up to 20 minutes
    /// for the new policy to take effect.
    /// </summary>
    public partial class PutMetricPolicyRequest : AmazonMediaStoreRequest
    {
        private string _containerName;
        private MetricPolicy _metricPolicy;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that you want to add the metric policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricPolicy. 
        /// <para>
        /// The metric policy that you want to associate with the container. In the policy, you
        /// must indicate whether you want MediaStore to send container-level metrics. You can
        /// also include up to five rules to define groups of objects that you want MediaStore
        /// to send object-level metrics for. If you include rules in the policy, construct each
        /// rule with both of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An object group that defines which objects to include in the group. The definition
        /// can be a path or a file name, but it can't have more than 900 characters. Valid characters
        /// are: a-z, A-Z, 0-9, _ (underscore), = (equal), : (colon), . (period), - (hyphen),
        /// ~ (tilde), / (forward slash), and * (asterisk). Wildcards (*) are acceptable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An object group name that allows you to refer to the object group. The name can't
        /// have more than 30 characters. Valid characters are: a-z, A-Z, 0-9, and _ (underscore).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricPolicy MetricPolicy
        {
            get { return this._metricPolicy; }
            set { this._metricPolicy = value; }
        }

        // Check to see if MetricPolicy property is set
        internal bool IsSetMetricPolicy()
        {
            return this._metricPolicy != null;
        }

    }
}