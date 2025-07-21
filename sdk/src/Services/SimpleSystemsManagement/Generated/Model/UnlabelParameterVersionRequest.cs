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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UnlabelParameterVersion operation.
    /// Remove a label or labels from a parameter.
    /// 
    ///  
    /// <para>
    /// Parameter names can't contain spaces. The service removes any spaces specified for
    /// the beginning or end of a parameter name. If the specified name for a parameter contains
    /// spaces between characters, the request fails with a <c>ValidationException</c> error.
    /// </para>
    /// </summary>
    public partial class UnlabelParameterVersionRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private long? _parameterVersion;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// One or more labels to delete from the specified parameter version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter from which you want to delete one or more labels.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't enter the Amazon Resource Name (ARN) for a parameter, only the parameter
        /// name itself.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property ParameterVersion. 
        /// <para>
        /// The specific version of the parameter which you want to delete one or more labels
        /// from. If it isn't present, the call will fail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ParameterVersion
        {
            get { return this._parameterVersion; }
            set { this._parameterVersion = value; }
        }

        // Check to see if ParameterVersion property is set
        internal bool IsSetParameterVersion()
        {
            return this._parameterVersion.HasValue; 
        }

    }
}