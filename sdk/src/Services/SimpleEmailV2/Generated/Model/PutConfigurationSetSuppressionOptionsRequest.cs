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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationSetSuppressionOptions operation.
    /// Specify the account suppression list preferences for a configuration set.
    /// </summary>
    public partial class PutConfigurationSetSuppressionOptionsRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _configurationSetName;
        private List<string> _suppressedReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to change the suppression list preferences for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressedReasons. 
        /// <para>
        /// A list that contains the reasons that email addresses are automatically added to the
        /// suppression list for your account. This list can contain any or all of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLAINT</c> – Amazon SES adds an email address to the suppression list for your
        /// account when a message sent to that address results in a complaint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOUNCE</c> – Amazon SES adds an email address to the suppression list for your
        /// account when a message sent to that address results in a hard bounce.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SuppressedReasons
        {
            get { return this._suppressedReasons; }
            set { this._suppressedReasons = value; }
        }

        // Check to see if SuppressedReasons property is set
        internal bool IsSetSuppressedReasons()
        {
            return this._suppressedReasons != null && (this._suppressedReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}