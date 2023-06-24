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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The record of a change within Audit Manager. For example, this could be the status
    /// change of an assessment or the delegation of a control set.
    /// </summary>
    public partial class ChangeLog
    {
        private ActionEnum _action;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _objectName;
        private ObjectTypeEnum _objectType;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        ///  The action that was performed. 
        /// </para>
        /// </summary>
        public ActionEnum Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time when the action was performed and the changelog record was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The user or role that performed the action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectName. 
        /// <para>
        ///  The name of the object that changed. This could be the name of an assessment, control,
        /// or control set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ObjectName
        {
            get { return this._objectName; }
            set { this._objectName = value; }
        }

        // Check to see if ObjectName property is set
        internal bool IsSetObjectName()
        {
            return this._objectName != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectType. 
        /// <para>
        ///  The object that was changed, such as an assessment, control, or control set. 
        /// </para>
        /// </summary>
        public ObjectTypeEnum ObjectType
        {
            get { return this._objectType; }
            set { this._objectType = value; }
        }

        // Check to see if ObjectType property is set
        internal bool IsSetObjectType()
        {
            return this._objectType != null;
        }

    }
}