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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExclusions operation.
    /// Describes the exclusions that are specified by the exclusions' ARNs.
    /// </summary>
    public partial class DescribeExclusionsRequest : AmazonInspectorRequest
    {
        private List<string> _exclusionArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Locale _locale;

        /// <summary>
        /// Gets and sets the property ExclusionArns. 
        /// <para>
        /// The list of ARNs that specify the exclusions that you want to describe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ExclusionArns
        {
            get { return this._exclusionArns; }
            set { this._exclusionArns = value; }
        }

        // Check to see if ExclusionArns property is set
        internal bool IsSetExclusionArns()
        {
            return this._exclusionArns != null && (this._exclusionArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale into which you want to translate the exclusion's title, description, and
        /// recommendation.
        /// </para>
        /// </summary>
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

    }
}