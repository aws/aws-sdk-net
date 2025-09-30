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
    /// Container for the parameters to the DeleteAccountCustomization operation.
    /// <important> 
    /// <para>
    /// This API permanently deletes all QuickSight customizations for the specified Amazon
    /// Web Services account and namespace in this Amazon Web Services Region. When you delete
    /// account customizations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// All customizations are removed including themes, branding, and visual settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The deletion affects only the specified Amazon Web Services Region - customizations
    /// in other regions remain unchanged
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This action cannot be undone through the API
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Users will see default QuickSight styling after customizations are deleted
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Before proceeding:</b> Ensure you have backups of any custom themes or branding
    /// elements you may want to recreate.
    /// </para>
    ///  </important> 
    /// <para>
    /// Deletes all Amazon QuickSight customizations in this Amazon Web Services Region for
    /// the specified Amazon Web Services account and QuickSight namespace.
    /// </para>
    /// </summary>
    public partial class DeleteAccountCustomizationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that you want to delete QuickSight customizations
        /// from in this Amazon Web Services Region.
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
        /// The QuickSight namespace that you're deleting the customizations from.
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