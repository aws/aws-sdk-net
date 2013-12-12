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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> </para>
    /// </summary>
    public partial class OptionGroup : AmazonWebServiceResponse
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

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }
    }
}
