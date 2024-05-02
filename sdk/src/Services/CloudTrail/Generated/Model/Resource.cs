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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Specifies the type and name of a resource referenced by an event.
    /// </summary>
    public partial class Resource
    {
        private string _resourceName;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource referenced by the event returned. These are user-created
        /// names whose values will depend on the environment. For example, the resource name
        /// might be "auto-scaling-test-group" for an Auto Scaling Group or "i-1234567" for an
        /// EC2 Instance.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of a resource referenced by the event returned. When the resource type cannot
        /// be determined, null is returned. Some examples of resource types are: <b>Instance</b>
        /// for EC2, <b>Trail</b> for CloudTrail, <b>DBInstance</b> for Amazon RDS, and <b>AccessKey</b>
        /// for IAM. To learn more about how to look up and filter events by the resource types
        /// supported for a service, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/view-cloudtrail-events-console.html#filtering-cloudtrail-events">Filtering
        /// CloudTrail Events</a>.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}