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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains information about which resources to include or exclude from a backup plan
    /// using their tags. Conditions are case sensitive.
    /// </summary>
    public partial class Conditions
    {
        private List<ConditionParameter> _stringEquals = new List<ConditionParameter>();
        private List<ConditionParameter> _stringLike = new List<ConditionParameter>();
        private List<ConditionParameter> _stringNotEquals = new List<ConditionParameter>();
        private List<ConditionParameter> _stringNotLike = new List<ConditionParameter>();

        /// <summary>
        /// Gets and sets the property StringEquals. 
        /// <para>
        /// Filters the values of your tagged resources for only those resources that you tagged
        /// with the same value. Also called "exact matching."
        /// </para>
        /// </summary>
        public List<ConditionParameter> StringEquals
        {
            get { return this._stringEquals; }
            set { this._stringEquals = value; }
        }

        // Check to see if StringEquals property is set
        internal bool IsSetStringEquals()
        {
            return this._stringEquals != null && this._stringEquals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringLike. 
        /// <para>
        /// Filters the values of your tagged resources for matching tag values with the use of
        /// a wildcard character (*) anywhere in the string. For example, "prod*" or "*rod*" matches
        /// the tag value "production".
        /// </para>
        /// </summary>
        public List<ConditionParameter> StringLike
        {
            get { return this._stringLike; }
            set { this._stringLike = value; }
        }

        // Check to see if StringLike property is set
        internal bool IsSetStringLike()
        {
            return this._stringLike != null && this._stringLike.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringNotEquals. 
        /// <para>
        /// Filters the values of your tagged resources for only those resources that you tagged
        /// that do not have the same value. Also called "negated matching."
        /// </para>
        /// </summary>
        public List<ConditionParameter> StringNotEquals
        {
            get { return this._stringNotEquals; }
            set { this._stringNotEquals = value; }
        }

        // Check to see if StringNotEquals property is set
        internal bool IsSetStringNotEquals()
        {
            return this._stringNotEquals != null && this._stringNotEquals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringNotLike. 
        /// <para>
        /// Filters the values of your tagged resources for non-matching tag values with the use
        /// of a wildcard character (*) anywhere in the string.
        /// </para>
        /// </summary>
        public List<ConditionParameter> StringNotLike
        {
            get { return this._stringNotLike; }
            set { this._stringNotLike = value; }
        }

        // Check to see if StringNotLike property is set
        internal bool IsSetStringNotLike()
        {
            return this._stringNotLike != null && this._stringNotLike.Count > 0; 
        }

    }
}