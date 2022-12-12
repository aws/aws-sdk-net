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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class OptionGroup
    {
        private bool? _allowsVpcAndNonVpcInstanceMemberships;
        private DateTime? _copyTimestamp;
        private string _engineName;
        private string _majorEngineVersion;
        private string _optionGroupArn;
        private string _optionGroupDescription;
        private string _optionGroupName;
        private List<Option> _options = new List<Option>();
        private string _sourceAccountId;
        private string _sourceOptionGroup;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AllowsVpcAndNonVpcInstanceMemberships. 
        /// <para>
        /// Indicates whether this option group can be applied to both VPC and non-VPC instances.
        /// The value <code>true</code> indicates the option group can be applied to both VPC
        /// and non-VPC instances.
        /// </para>
        /// </summary>
        public bool AllowsVpcAndNonVpcInstanceMemberships
        {
            get { return this._allowsVpcAndNonVpcInstanceMemberships.GetValueOrDefault(); }
            set { this._allowsVpcAndNonVpcInstanceMemberships = value; }
        }

        // Check to see if AllowsVpcAndNonVpcInstanceMemberships property is set
        internal bool IsSetAllowsVpcAndNonVpcInstanceMemberships()
        {
            return this._allowsVpcAndNonVpcInstanceMemberships.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTimestamp. 
        /// <para>
        /// Indicates when the option group was copied.
        /// </para>
        /// </summary>
        public DateTime CopyTimestamp
        {
            get { return this._copyTimestamp.GetValueOrDefault(); }
            set { this._copyTimestamp = value; }
        }

        // Check to see if CopyTimestamp property is set
        internal bool IsSetCopyTimestamp()
        {
            return this._copyTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// Indicates the name of the engine that this option group can be applied to.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// Indicates the major engine version associated with this option group.
        /// </para>
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) for the option group.
        /// </para>
        /// </summary>
        public string OptionGroupArn
        {
            get { return this._optionGroupArn; }
            set { this._optionGroupArn = value; }
        }

        // Check to see if OptionGroupArn property is set
        internal bool IsSetOptionGroupArn()
        {
            return this._optionGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupDescription. 
        /// <para>
        /// Provides a description of the option group.
        /// </para>
        /// </summary>
        public string OptionGroupDescription
        {
            get { return this._optionGroupDescription; }
            set { this._optionGroupDescription = value; }
        }

        // Check to see if OptionGroupDescription property is set
        internal bool IsSetOptionGroupDescription()
        {
            return this._optionGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// Specifies the name of the option group.
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
        /// Gets and sets the property Options. 
        /// <para>
        /// Indicates what options are available in the option group.
        /// </para>
        /// </summary>
        public List<Option> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// Specifies the Amazon Web Services account ID for the option group from which this
        /// option group is copied.
        /// </para>
        /// </summary>
        public string SourceAccountId
        {
            get { return this._sourceAccountId; }
            set { this._sourceAccountId = value; }
        }

        // Check to see if SourceAccountId property is set
        internal bool IsSetSourceAccountId()
        {
            return this._sourceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceOptionGroup. 
        /// <para>
        /// Specifies the name of the option group from which this option group is copied.
        /// </para>
        /// </summary>
        public string SourceOptionGroup
        {
            get { return this._sourceOptionGroup; }
            set { this._sourceOptionGroup = value; }
        }

        // Check to see if SourceOptionGroup property is set
        internal bool IsSetSourceOptionGroup()
        {
            return this._sourceOptionGroup != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// If <b>AllowsVpcAndNonVpcInstanceMemberships</b> is <code>false</code>, this field
        /// is blank. If <b>AllowsVpcAndNonVpcInstanceMemberships</b> is <code>true</code> and
        /// this field is blank, then this option group can be applied to both VPC and non-VPC
        /// instances. If this field contains a value, then this option group can only be applied
        /// to instances that are in the VPC indicated by this field.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}