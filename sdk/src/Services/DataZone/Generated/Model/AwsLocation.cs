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
    /// The location of a project.
    /// </summary>
    public partial class AwsLocation
    {
        private string _accessRole;
        private string _awsAccountId;
        private string _awsRegion;
        private string _iamConnectionId;

        /// <summary>
        /// Gets and sets the property AccessRole. 
        /// <para>
        /// The access role of a connection.
        /// </para>
        /// </summary>
        public string AccessRole
        {
            get { return this._accessRole; }
            set { this._accessRole = value; }
        }

        // Check to see if AccessRole property is set
        internal bool IsSetAccessRole()
        {
            return this._accessRole != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The account ID of a connection.
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
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Region of a connection.
        /// </para>
        /// </summary>
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IamConnectionId. 
        /// <para>
        /// The IAM connection ID of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string IamConnectionId
        {
            get { return this._iamConnectionId; }
            set { this._iamConnectionId = value; }
        }

        // Check to see if IamConnectionId property is set
        internal bool IsSetIamConnectionId()
        {
            return this._iamConnectionId != null;
        }

    }
}