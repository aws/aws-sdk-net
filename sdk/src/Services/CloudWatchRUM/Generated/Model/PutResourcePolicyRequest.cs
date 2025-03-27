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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Use this operation to assign a resource-based policy to a CloudWatch RUM app monitor
    /// to control access to it. Each app monitor can have one resource-based policy. The
    /// maximum size of the policy is 4 KB. To learn more about using resource policies with
    /// RUM, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-resource-policies.html">Using
    /// resource-based policies with CloudWatch RUM</a>.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonCloudWatchRUMRequest
    {
        private string _name;
        private string _policyDocument;
        private string _policyRevisionId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app monitor that you want to apply this resource-based policy to.
        /// To find the names of your app monitors, you can use the <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_ListAppMonitors.html">ListAppMonitors</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON to use as the resource policy. The document can be up to 4 KB in size. For
        /// more information about the contents and syntax for this policy, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-resource-policies.html">Using
        /// resource-based policies with CloudWatch RUM</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// A string value that you can use to conditionally update your policy. You can provide
        /// the revision ID of your existing policy to make mutating requests against that policy.
        /// </para>
        ///  
        /// <para>
        /// When you assign a policy revision ID, then later requests about that policy will be
        /// rejected with an <c>InvalidPolicyRevisionIdException</c> error if they don't provide
        /// the correct current revision ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PolicyRevisionId
        {
            get { return this._policyRevisionId; }
            set { this._policyRevisionId = value; }
        }

        // Check to see if PolicyRevisionId property is set
        internal bool IsSetPolicyRevisionId()
        {
            return this._policyRevisionId != null;
        }

    }
}