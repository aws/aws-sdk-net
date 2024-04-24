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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details for the resource.
    /// </summary>
    public partial class ResourceDetails
    {
        private EC2ResourceDetails _ec2ResourceDetails;

        /// <summary>
        /// Gets and sets the property EC2ResourceDetails. 
        /// <para>
        /// Details for the Amazon EC2 resource.
        /// </para>
        /// </summary>
        public EC2ResourceDetails EC2ResourceDetails
        {
            get { return this._ec2ResourceDetails; }
            set { this._ec2ResourceDetails = value; }
        }

        // Check to see if EC2ResourceDetails property is set
        internal bool IsSetEC2ResourceDetails()
        {
            return this._ec2ResourceDetails != null;
        }

    }
}