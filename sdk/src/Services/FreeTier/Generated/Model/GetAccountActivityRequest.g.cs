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

namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountActivity operation. Returns a specific
    /// activity record that is available to the customer.
    /// </summary>
    public partial class GetAccountActivityRequest : AmazonFreeTierRequest
    {
        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        ///  A unique identifier that identifies the activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Checks to see if the ActivityId property is set.
        /// </summary>
        internal bool IsSetActivityId() => this.ActivityId != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        ///  The language code used to return translated title and description fields. 
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;
    }
}
