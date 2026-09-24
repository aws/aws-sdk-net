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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The record of a change within Audit Manager. For example, this could be the status
    /// change of an assessment or the delegation of a control set.
    /// </summary>
    public partial class ChangeLog
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        ///  The action that was performed. 
        /// </para>
        /// </summary>
        public ActionEnum Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time when the action was performed and the changelog record was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The user or role that performed the action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property ObjectName. 
        /// <para>
        ///  The name of the object that changed. This could be the name of an assessment, control,
        /// or control set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ObjectName { get; set; }

        /// <summary>
        /// Checks to see if the ObjectName property is set.
        /// </summary>
        internal bool IsSetObjectName() => this.ObjectName != null;

        /// <summary>
        /// Gets and sets the property ObjectType. 
        /// <para>
        ///  The object that was changed, such as an assessment, control, or control set. 
        /// </para>
        /// </summary>
        public ObjectTypeEnum ObjectType { get; set; }

        /// <summary>
        /// Checks to see if the ObjectType property is set.
        /// </summary>
        internal bool IsSetObjectType() => this.ObjectType != null;
    }
}
