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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeExclusions operation.
    /// Describes the exclusions that are specified by the exclusions' ARNs.
    /// </summary>
    public partial class DescribeExclusionsRequest : AmazonInspectorRequest
    {
        private List<string> _exclusionArns = new List<string>();
        private Locale _locale;

        /// <summary>
        /// Gets and sets the property ExclusionArns. 
        /// <para>
        /// The list of ARNs that specify the exclusions that you want to describe.
        /// </para>
        /// </summary>
        public List<string> ExclusionArns
        {
            get { return this._exclusionArns; }
            set { this._exclusionArns = value; }
        }

        // Check to see if ExclusionArns property is set
        internal bool IsSetExclusionArns()
        {
            return this._exclusionArns != null && this._exclusionArns.Count > 0; 
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