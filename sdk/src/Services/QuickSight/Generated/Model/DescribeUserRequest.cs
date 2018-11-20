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

/*
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeUser operation.
    /// Returns information about a user, given the user name. 
    /// 
    ///  
    /// <para>
    /// The permission resource is <code>arn:aws:quicksight:us-east-1:<i>&lt;aws-account-id&gt;</i>:user/default/<i>&lt;user-name&gt;</i>
    /// </code>. 
    /// </para>
    ///  
    /// <para>
    /// The response is a user object that contains the user's Amazon Resource Name (ARN),
    /// AWS Identity and Access Management (IAM) role, and email address. 
    /// </para>
    /// </summary>
    public partial class DescribeUserRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _awsNamespace;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that the user is in. Currently, you use the ID for the
        /// AWS account that contains your Amazon QuickSight account.
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace. Currently, you should set this to <code>default</code>.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user that you want to describe.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}