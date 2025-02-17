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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// The account ID of a project.
    /// </summary>
    public partial class AwsAccount
    {
        private string _awsAccountId;
        private string _awsAccountIdPath;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The account ID of a project.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountIdPath. 
        /// <para>
        /// The account ID path of a project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AwsAccountIdPath
        {
            get { return this._awsAccountIdPath; }
            set { this._awsAccountIdPath = value; }
        }

        // Check to see if AwsAccountIdPath property is set
        internal bool IsSetAwsAccountIdPath()
        {
            return this._awsAccountIdPath != null;
        }

    }
}