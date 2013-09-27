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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> </para>
    /// </summary>
    public class OptionGroup
    {
        
        private string optionGroupName;
        private string optionGroupDescription;
        private string engineName;
        private string majorEngineVersion;
        private List<Option> options = new List<Option>();
        private bool? allowsVpcAndNonVpcInstanceMemberships;
        private string vpcId;

        /// <summary>
        /// Specifies the name of the option group.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithOptionGroupName(string optionGroupName)
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
        /// Provides the description of the option group.
        ///  
        /// </summary>
        public string OptionGroupDescription
        {
            get { return this.optionGroupDescription; }
            set { this.optionGroupDescription = value; }
        }

        /// <summary>
        /// Sets the OptionGroupDescription property
        /// </summary>
        /// <param name="optionGroupDescription">The value to set for the OptionGroupDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithOptionGroupDescription(string optionGroupDescription)
        {
            this.optionGroupDescription = optionGroupDescription;
            return this;
        }
            

        // Check to see if OptionGroupDescription property is set
        internal bool IsSetOptionGroupDescription()
        {
            return this.optionGroupDescription != null;
        }

        /// <summary>
        /// Engine name that this option group can be applied to.
        ///  
        /// </summary>
        public string EngineName
        {
            get { return this.engineName; }
            set { this.engineName = value; }
        }

        /// <summary>
        /// Sets the EngineName property
        /// </summary>
        /// <param name="engineName">The value to set for the EngineName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithEngineName(string engineName)
        {
            this.engineName = engineName;
            return this;
        }
            

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this.engineName != null;
        }

        /// <summary>
        /// Indicates the major engine version associated with this option group.
        ///  
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this.majorEngineVersion; }
            set { this.majorEngineVersion = value; }
        }

        /// <summary>
        /// Sets the MajorEngineVersion property
        /// </summary>
        /// <param name="majorEngineVersion">The value to set for the MajorEngineVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithMajorEngineVersion(string majorEngineVersion)
        {
            this.majorEngineVersion = majorEngineVersion;
            return this;
        }
            

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this.majorEngineVersion != null;
        }

        /// <summary>
        /// Indicates what options are available in the option group.
        ///  
        /// </summary>
        public List<Option> Options
        {
            get { return this.options; }
            set { this.options = value; }
        }
        /// <summary>
        /// Adds elements to the Options collection
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithOptions(params Option[] options)
        {
            foreach (Option element in options)
            {
                this.options.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Options collection
        /// </summary>
        /// <param name="options">The values to add to the Options collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithOptions(IEnumerable<Option> options)
        {
            foreach (Option element in options)
            {
                this.options.Add(element);
            }

            return this;
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options.Count > 0;
        }

        /// <summary>
        /// Indicates whether this option group can be applied to both VPC and non-VPC instances. The value 'true' indicates the option group can be
        /// applied to both VPC and non-VPC instances.
        ///  
        /// </summary>
        public bool AllowsVpcAndNonVpcInstanceMemberships
        {
            get { return this.allowsVpcAndNonVpcInstanceMemberships ?? default(bool); }
            set { this.allowsVpcAndNonVpcInstanceMemberships = value; }
        }

        /// <summary>
        /// Sets the AllowsVpcAndNonVpcInstanceMemberships property
        /// </summary>
        /// <param name="allowsVpcAndNonVpcInstanceMemberships">The value to set for the AllowsVpcAndNonVpcInstanceMemberships property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithAllowsVpcAndNonVpcInstanceMemberships(bool allowsVpcAndNonVpcInstanceMemberships)
        {
            this.allowsVpcAndNonVpcInstanceMemberships = allowsVpcAndNonVpcInstanceMemberships;
            return this;
        }
            

        // Check to see if AllowsVpcAndNonVpcInstanceMemberships property is set
        internal bool IsSetAllowsVpcAndNonVpcInstanceMemberships()
        {
            return this.allowsVpcAndNonVpcInstanceMemberships.HasValue;
        }

        /// <summary>
        /// If AllowsVpcAndNonVpcInstanceMemberships is 'false', this field is blank. If AllowsVpcAndNonVpcInstanceMemberships is 'true' and this field
        /// is blank, then this option group can be applied to both VPC and non-VPC instances. If this field contains a value, then this option group
        /// can only be applied to instances that are in the VPC indicated by this field.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionGroup WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
        }
            

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }
    }
}
