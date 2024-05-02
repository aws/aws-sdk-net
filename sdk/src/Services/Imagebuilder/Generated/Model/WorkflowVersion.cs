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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about this version of the workflow.
    /// </summary>
    public partial class WorkflowVersion
    {
        private string _arn;
        private string _dateCreated;
        private string _description;
        private string _name;
        private string _owner;
        private WorkflowType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The timestamp when Image Builder created the workflow version.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The name of the workflow.
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the workflow resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The image creation stage that this workflow applies to. Image Builder currently supports
        /// build and test stage workflows.
        /// </para>
        /// </summary>
        public WorkflowType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The semantic version of the workflow resource. The format includes three nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}