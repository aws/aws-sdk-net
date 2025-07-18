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
    /// Container for the parameters to the LabelParameterVersion operation.
    /// A parameter label is a user-defined alias to help you manage different versions of
    /// a parameter. When you modify a parameter, Amazon Web Services Systems Manager automatically
    /// saves a new version and increments the version number by one. A label can help you
    /// remember the purpose of a parameter when there are multiple versions. 
    /// 
    ///  
    /// <para>
    /// Parameter labels have the following requirements and restrictions.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A version of a parameter can have a maximum of 10 labels.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't attach the same label to different versions of the same parameter. For example,
    /// if version 1 has the label Production, then you can't attach Production to version
    /// 2.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can move a label from one version of a parameter to another.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't create a label when you create a new parameter. You must attach a label
    /// to a specific version of a parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you no longer want to use a parameter label, then you can either delete it or move
    /// it to a different version of a parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A label can have a maximum of 100 characters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Labels can contain letters (case sensitive), numbers, periods (.), hyphens (-), or
    /// underscores (_).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Labels can't begin with a number, "<c>aws</c>" or "<c>ssm</c>" (not case sensitive).
    /// If a label fails to meet these requirements, then the label isn't associated with
    /// a parameter and the system displays it in the list of InvalidLabels.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parameter names can't contain spaces. The service removes any spaces specified for
    /// the beginning or end of a parameter name. If the specified name for a parameter contains
    /// spaces between characters, the request fails with a <c>ValidationException</c> error.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LabelParameterVersionRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private long? _parameterVersion;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// One or more labels to attach to the specified parameter version.
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
        /// The parameter name on which you want to attach one or more labels.
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
        /// The specific version of the parameter on which you want to attach one or more labels.
        /// If no version is specified, the system attaches the label to the latest version.
        /// </para>
        /// </summary>
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