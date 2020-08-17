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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccountCustomization operation.
    /// Creates Amazon QuickSight customizations the current AWS Region. Currently, you can
    /// add a custom default theme by using the <code>CreateAccountCustomization</code> or
    /// <code>UpdateAccountCustomization</code> API operation. To further customize QuickSight
    /// by removing QuickSight sample assets and videos for all new users, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-quicksight.html">Customizing
    /// QuickSight</a> in the Amazon QuickSight User Guide.
    /// 
    ///  
    /// <para>
    /// You can create customizations for your AWS account or, if you specify a namespace,
    /// for a QuickSight namespace instead. Customizations that apply to a namespace always
    /// override customizations that apply to an AWS account. To find out which customizations
    /// apply, use the <code>DescribeAccountCustomization</code> API operation.
    /// </para>
    ///  
    /// <para>
    /// Before you add a theme as the namespace default, make sure that you first share the
    /// theme with the namespace. If you don't share it with the namespace, the theme won't
    /// be visible to your users even if you use this API operation to make it the default
    /// theme. 
    /// </para>
    /// </summary>
    public partial class CreateAccountCustomizationRequest : AmazonQuickSightRequest
    {
        private AccountCustomization _accountCustomization;
        private string _awsAccountId;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property AccountCustomization. 
        /// <para>
        /// The QuickSight customizations you're adding in the current AWS Region. You can add
        /// these to an AWS account and a QuickSight namespace. 
        /// </para>
        ///  
        /// <para>
        /// For example, you could add a default theme by setting <code>AccountCustomization</code>
        /// to the midnight theme: <code>"AccountCustomization": { "DefaultTheme": "arn:aws:quicksight::aws:theme/MIDNIGHT"
        /// }. </code>. Or, you could add a custom theme by specifying <code>"AccountCustomization":
        /// { "DefaultTheme": "arn:aws:quicksight:us-west-2:111122223333:theme/bdb844d0-0fe9-4d9d-b520-0fe602d93639"
        /// }</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountCustomization AccountCustomization
        {
            get { return this._accountCustomization; }
            set { this._accountCustomization = value; }
        }

        // Check to see if AccountCustomization property is set
        internal bool IsSetAccountCustomization()
        {
            return this._accountCustomization != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that you want to customize QuickSight for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// The QuickSight namespace that you want to add customizations to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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

    }
}