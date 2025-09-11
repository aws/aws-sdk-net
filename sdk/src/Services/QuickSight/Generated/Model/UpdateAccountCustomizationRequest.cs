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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountCustomization operation.
    /// Updates Amazon QuickSight customizations for the current Amazon Web Services Region.
    /// Currently, the only customization that you can use is a theme.
    /// 
    ///  
    /// <para>
    /// You can use customizations for your Amazon Web Services account or, if you specify
    /// a namespace, for a QuickSight namespace instead. Customizations that apply to a namespace
    /// override customizations that apply to an Amazon Web Services account. To find out
    /// which customizations apply, use the <c>DescribeAccountCustomization</c> API operation.
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateAccountCustomizationRequest : AmazonQuickSightRequest
    {
        private AccountCustomization _accountCustomization;
        private string _awsAccountId;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property AccountCustomization. 
        /// <para>
        /// The QuickSight customizations you're updating in the current Amazon Web Services Region.
        /// 
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
        /// The ID for the Amazon Web Services account that you want to update QuickSight customizations
        /// for.
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
        /// The namespace that you want to update QuickSight customizations for.
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