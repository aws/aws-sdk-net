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
    /// <para> Modifies an existing Option Group. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.ModifyOptionGroup"/>
    public class ModifyOptionGroupRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the OptionGroupName property
        /// </summary>
        /// <param name="optionGroupName">The value to set for the OptionGroupName property </param>
        /// <returns>this instance</returns>
        public ModifyOptionGroupRequest WithOptionGroupName(string optionGroupName)
        {
            this.optionGroupName = optionGroupName;
            return this;
        }
            

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

        /// <summary>
        /// Options in this list are added to the Option Group or, if already present, the specified configuration is used to update the existing
        /// configuration.
        ///  
        /// </summary>
        public List<OptionConfiguration> OptionsToInclude
        {
            get { return this.optionsToInclude; }
            set { this.optionsToInclude = value; }
        }
        /// <summary>
        /// Adds elements to the OptionsToInclude collection
        /// </summary>
        /// <param name="optionsToInclude">The values to add to the OptionsToInclude collection </param>
        /// <returns>this instance</returns>
        public ModifyOptionGroupRequest WithOptionsToInclude(params OptionConfiguration[] optionsToInclude)
        {
            foreach (OptionConfiguration element in optionsToInclude)
            {
                this.optionsToInclude.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the OptionsToInclude collection
        /// </summary>
        /// <param name="optionsToInclude">The values to add to the OptionsToInclude collection </param>
        /// <returns>this instance</returns>
        public ModifyOptionGroupRequest WithOptionsToInclude(IEnumerable<OptionConfiguration> optionsToInclude)
        {
            foreach (OptionConfiguration element in optionsToInclude)
            {
                this.optionsToInclude.Add(element);
            }

            return this;
        }

        // Check to see if OptionsToInclude property is set
        internal bool IsSetOptionsToInclude()
        {
            return this.optionsToInclude.Count > 0;
        }

        /// <summary>
        /// Options in this list are removed from the Option Group.
        ///  
        /// </summary>
        public List<string> OptionsToRemove
        {
            get { return this.optionsToRemove; }
            set { this.optionsToRemove = value; }
        }
        /// <summary>
        /// Adds elements to the OptionsToRemove collection
        /// </summary>
        /// <param name="optionsToRemove">The values to add to the OptionsToRemove collection </param>
        /// <returns>this instance</returns>
        public ModifyOptionGroupRequest WithOptionsToRemove(params string[] optionsToRemove)
        {
            foreach (string element in optionsToRemove)
            {
                this.optionsToRemove.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the OptionsToRemove collection
        /// </summary>
        /// <param name="optionsToRemove">The values to add to the OptionsToRemove collection </param>
        /// <returns>this instance</returns>
        public ModifyOptionGroupRequest WithOptionsToRemove(IEnumerable<string> optionsToRemove)
        {
            foreach (string element in optionsToRemove)
            {
                this.optionsToRemove.Add(element);
            }

            return this;
        }

        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this.optionsToRemove.Count > 0;
        }

        /// <summary>
        /// Indicates whether the changes should be applied immediately, or during the next maintenance window for each instance associated with the
        /// Option Group.
        ///  
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this.applyImmediately ?? default(bool); }
            set { this.applyImmediately = value; }
        }

        /// <summary>
        /// Sets the ApplyImmediately property
        /// </summary>
        /// <param name="applyImmediately">The value to set for the ApplyImmediately property </param>
        /// <returns>this instance</returns>
        public ModifyOptionGroupRequest WithApplyImmediately(bool applyImmediately)
        {
            this.applyImmediately = applyImmediately;
            return this;
        }
            

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this.applyImmediately.HasValue;
        }
    }
}
    
