/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Modifies an existing option group. </para>
    /// </summary>
    public partial class ModifyOptionGroupRequest : AmazonRDSRequest
    {
        private string optionGroupName;
        private List<OptionConfiguration> optionsToInclude = new List<OptionConfiguration>();
        private List<string> optionsToRemove = new List<string>();
        private bool? applyImmediately;


        /// <summary>
        /// The name of the option group to be modified. <!-- Note that persistent options, such as the TDE_SQLServer option for Microsoft SQL Server,
        /// cannot be removed from an option group while DB instances are associated with the option group. --> Permanent options, such as the TDE
        /// option for Oracle Advanced Security TDE, cannot be removed from an option group, and that option group cannot be removed from a DB instance
        /// once it is associated with a DB instance
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

        /// <summary>
        /// Options in this list are added to the option group or, if already present, the specified configuration is used to update the existing
        /// configuration.
        ///  
        /// </summary>
        public List<OptionConfiguration> OptionsToInclude
        {
            get { return this.optionsToInclude; }
            set { this.optionsToInclude = value; }
        }

        // Check to see if OptionsToInclude property is set
        internal bool IsSetOptionsToInclude()
        {
            return this.optionsToInclude.Count > 0;
        }

        /// <summary>
        /// Options in this list are removed from the option group.
        ///  
        /// </summary>
        public List<string> OptionsToRemove
        {
            get { return this.optionsToRemove; }
            set { this.optionsToRemove = value; }
        }

        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this.optionsToRemove.Count > 0;
        }

        /// <summary>
        /// Indicates whether the changes should be applied immediately, or during the next maintenance window for each instance associated with the
        /// option group.
        ///  
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this.applyImmediately ?? default(bool); }
            set { this.applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this.applyImmediately.HasValue;
        }

    }
}
    
