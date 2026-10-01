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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccountCustomization operation. <important>
    /// <para> This API permanently deletes all Quick Sight customizations for the specified
    /// Amazon Web Services account and namespace. When you delete account customizations:
    /// </para> <ul> <li> <para> All customizations are removed including themes, branding,
    /// and visual settings </para> </li> <li> <para> This action cannot be undone through
    /// the API </para> </li> <li> <para> Users will see default Quick Sight styling after
    /// customizations are deleted </para> </li> </ul> <para> <b>Before proceeding:</b> Ensure
    /// you have backups of any custom themes or branding elements you may want to recreate.
    /// </para> </important> <para> Deletes all Amazon Quick Sight customizations for the
    /// specified Amazon Web Services account and Quick Sight namespace. </para>
    /// </summary>
    public partial class DeleteAccountCustomizationRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that you want to delete Quick Sight customizations
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Quick Sight namespace that you're deleting the customizations from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;
    }
}
