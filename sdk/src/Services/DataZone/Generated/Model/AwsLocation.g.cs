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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The location of a project.
    /// </summary>
    public partial class AwsLocation
    {
        /// <summary>
        /// Gets and sets the property AccessRole. 
        /// <para>
        /// The access role of a connection.
        /// </para>
        /// </summary>
        public string AccessRole { get; set; }

        /// <summary>
        /// Checks to see if the AccessRole property is set.
        /// </summary>
        internal bool IsSetAccessRole() => this.AccessRole != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The account ID of a connection.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Region of a connection.
        /// </para>
        /// </summary>
        public string AwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsRegion property is set.
        /// </summary>
        internal bool IsSetAwsRegion() => this.AwsRegion != null;

        /// <summary>
        /// Gets and sets the property IamConnectionId. 
        /// <para>
        /// The IAM connection ID of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string IamConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the IamConnectionId property is set.
        /// </summary>
        internal bool IsSetIamConnectionId() => this.IamConnectionId != null;
    }
}
