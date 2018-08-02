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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the LabelParameterVersion operation.
    /// A parameter label is a user-defined alias to help you manage different versions of
    /// a parameter. When you modify a parameter, Systems Manager automatically saves a new
    /// version and increments the version number by one. A label can help you remember the
    /// purpose of a parameter when there are multiple versions. 
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
    /// You can't delete a parameter label. If you no longer want to use a parameter label,
    /// then you must move it to a different version of a parameter.
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
    /// Labels can't begin with a number, "aws," or "ssm" (not case sensitive). If a label
    /// fails to meet these requirements, then the label is not associated with a parameter
    /// and the system displays it in the list of InvalidLabels.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LabelParameterVersionRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _labels = new List<string>();
        private string _name;
        private long? _parameterVersion;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// One or more labels to attach to the specified parameter version.
        /// </para>
        /// </summary>
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The parameter name on which you want to attach one or more labels.
        /// </para>
        /// </summary>
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
        /// If no version is specified, the system attaches the label to the latest version.)
        /// </para>
        /// </summary>
        public long ParameterVersion
        {
            get { return this._parameterVersion.GetValueOrDefault(); }
            set { this._parameterVersion = value; }
        }

        // Check to see if ParameterVersion property is set
        internal bool IsSetParameterVersion()
        {
            return this._parameterVersion.HasValue; 
        }

    }
}