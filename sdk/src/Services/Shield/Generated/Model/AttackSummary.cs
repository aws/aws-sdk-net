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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Summarizes all DDoS attacks for a specified time period.
    /// </summary>
    public partial class AttackSummary
    {
        private string _attackId;
        private List<AttackVectorDescription> _attackVectors = AWSConfigs.InitializeCollections ? new List<AttackVectorDescription>() : null;
        private DateTime? _endTime;
        private string _resourceArn;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AttackId. 
        /// <para>
        /// The unique identifier (ID) of the attack.
        /// </para>
        /// </summary>
        public string AttackId
        {
            get { return this._attackId; }
            set { this._attackId = value; }
        }

        // Check to see if AttackId property is set
        internal bool IsSetAttackId()
        {
            return this._attackId != null;
        }

        /// <summary>
        /// Gets and sets the property AttackVectors. 
        /// <para>
        /// The list of attacks for a specified time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttackVectorDescription> AttackVectors
        {
            get { return this._attackVectors; }
            set { this._attackVectors = value; }
        }

        // Check to see if AttackVectors property is set
        internal bool IsSetAttackVectors()
        {
            return this._attackVectors != null && (this._attackVectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the attack, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the resource that was attacked.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the attack, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}