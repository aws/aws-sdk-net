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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a change to a resource attribute.
    /// </summary>
    public partial class ResourceChangeDetail
    {
        private string _causingEntity;
        private EvaluationType _evaluation;
        private ResourceTargetDefinition _target;

        /// <summary>
        /// Gets and sets the property CausingEntity. 
        /// <para>
        /// The ID of the entity that caused the change.
        /// </para>
        /// </summary>
        public string CausingEntity
        {
            get { return this._causingEntity; }
            set { this._causingEntity = value; }
        }

        // Check to see if CausingEntity property is set
        internal bool IsSetCausingEntity()
        {
            return this._causingEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Evaluation. 
        /// <para>
        /// For static evaluations, the value of the resource attribute will change and the new
        /// value is known. For dynamic evaluations, the value might change, and any new value
        /// will be determined when the plan is updated.
        /// </para>
        /// </summary>
        public EvaluationType Evaluation
        {
            get { return this._evaluation; }
            set { this._evaluation = value; }
        }

        // Check to see if Evaluation property is set
        internal bool IsSetEvaluation()
        {
            return this._evaluation != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Information about the resource attribute to be modified.
        /// </para>
        /// </summary>
        public ResourceTargetDefinition Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}