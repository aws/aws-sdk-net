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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// This is the response object from the GetControl operation.
    /// </summary>
    public partial class GetControlResponse : AmazonWebServiceResponse
    {
        private List<string> _aliases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private ControlBehavior _behavior;
        private DateTime? _createTime;
        private string _description;
        private List<string> _governedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ImplementationDetails _implementation;
        private string _name;
        private List<ControlParameter> _parameters = AWSConfigs.InitializeCollections ? new List<ControlParameter>() : null;
        private RegionConfiguration _regionConfiguration;
        private ControlSeverity _severity;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A list of alternative identifiers for the control. These are human-readable designators,
        /// such as <c>SH.S3.1</c>. Several aliases can refer to the same control across different
        /// Amazon Web Services services or compliance frameworks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && (this._aliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// A term that identifies the control's functional behavior. One of <c>Preventive</c>,
        /// <c>Detective</c>, <c>Proactive</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlBehavior Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp that notes the time when the control was released (start of its life)
        /// as a governance capability in Amazon Web Services.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the control does.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GovernedResources. 
        /// <para>
        /// A list of Amazon Web Services resource types that are governed by this control. This
        /// information helps you understand which controls can govern certain types of resources,
        /// and conversely, which resources are affected when the control is implemented. The
        /// resources are represented as Amazon Web Services CloudFormation resource types. If
        /// <c>GovernedResources</c> cannot be represented by available CloudFormation resource
        /// types, it’s returned as an empty list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GovernedResources
        {
            get { return this._governedResources; }
            set { this._governedResources = value; }
        }

        // Check to see if GovernedResources property is set
        internal bool IsSetGovernedResources()
        {
            return this._governedResources != null && (this._governedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Implementation. 
        /// <para>
        /// Returns information about the control, as an <c>ImplementationDetails</c> object that
        /// shows the underlying implementation type for a control.
        /// </para>
        /// </summary>
        public ImplementationDetails Implementation
        {
            get { return this._implementation; }
            set { this._implementation = value; }
        }

        // Check to see if Implementation property is set
        internal bool IsSetImplementation()
        {
            return this._implementation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Returns an array of <c>ControlParameter</c> objects that specify the parameters a
        /// control supports. An empty list is returned for controls that don’t support parameters.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ControlParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionConfiguration RegionConfiguration
        {
            get { return this._regionConfiguration; }
            set { this._regionConfiguration = value; }
        }

        // Check to see if RegionConfiguration property is set
        internal bool IsSetRegionConfiguration()
        {
            return this._regionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// An enumerated type, with the following possible values:
        /// </para>
        /// </summary>
        public ControlSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

    }
}