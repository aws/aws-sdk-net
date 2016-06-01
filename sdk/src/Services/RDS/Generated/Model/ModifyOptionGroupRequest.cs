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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyOptionGroup operation.
    /// Modifies an existing option group.
    /// </summary>
    public partial class ModifyOptionGroupRequest : AmazonRDSRequest
    {
        private bool? _applyImmediately;
        private string _optionGroupName;
        private List<OptionConfiguration> _optionsToInclude = new List<OptionConfiguration>();
        private List<string> _optionsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates whether the changes should be applied immediately, or during the next maintenance
        /// window for each instance associated with the option group.
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The name of the option group to be modified.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, cannot
        /// be removed from an option group, and that option group cannot be removed from a DB
        /// instance once it is associated with a DB instance
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionsToInclude. 
        /// <para>
        /// Options in this list are added to the option group or, if already present, the specified
        /// configuration is used to update the existing configuration.
        /// </para>
        /// </summary>
        public List<OptionConfiguration> OptionsToInclude
        {
            get { return this._optionsToInclude; }
            set { this._optionsToInclude = value; }
        }

        // Check to see if OptionsToInclude property is set
        internal bool IsSetOptionsToInclude()
        {
            return this._optionsToInclude != null && this._optionsToInclude.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        /// Options in this list are removed from the option group.
        /// </para>
        /// </summary>
        public List<string> OptionsToRemove
        {
            get { return this._optionsToRemove; }
            set { this._optionsToRemove = value; }
        }

        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this._optionsToRemove != null && this._optionsToRemove.Count > 0; 
        }

    }
}