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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
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
namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProject operation.
    /// Changes one or more values for a project.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonCodeCatalystRequest
    {
        private string _description;
        private string _name;
        private string _spaceName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

    }
}