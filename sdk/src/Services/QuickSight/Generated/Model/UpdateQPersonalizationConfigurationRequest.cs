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
    /// Container for the parameters to the UpdateQPersonalizationConfiguration operation.
    /// Updates a personalization configuration.
    /// </summary>
    public partial class UpdateQPersonalizationConfigurationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private PersonalizationMode _personalizationMode;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account account that contains the personalization
        /// configuration that the user wants to update.
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
        /// Gets and sets the property PersonalizationMode. 
        /// <para>
        /// An option to allow QuickSight to customize data stories with user specific metadata,
        /// specifically location and job information, in your IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PersonalizationMode PersonalizationMode
        {
            get { return this._personalizationMode; }
            set { this._personalizationMode = value; }
        }

        // Check to see if PersonalizationMode property is set
        internal bool IsSetPersonalizationMode()
        {
            return this._personalizationMode != null;
        }

    }
}