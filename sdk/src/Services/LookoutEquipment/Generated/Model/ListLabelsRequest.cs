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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListLabels operation.
    /// Provides a list of labels.
    /// </summary>
    public partial class ListLabelsRequest : AmazonLookoutEquipmentRequest
    {
        private string _equipment;
        private string _faultCode;
        private DateTime? _intervalEndTime;
        private DateTime? _intervalStartTime;
        private string _labelGroupName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Equipment. 
        /// <para>
        ///  Lists the labels that pertain to a particular piece of equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Equipment
        {
            get { return this._equipment; }
            set { this._equipment = value; }
        }

        // Check to see if Equipment property is set
        internal bool IsSetEquipment()
        {
            return this._equipment != null;
        }

        /// <summary>
        /// Gets and sets the property FaultCode. 
        /// <para>
        ///  Returns labels with a particular fault code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string FaultCode
        {
            get { return this._faultCode; }
            set { this._faultCode = value; }
        }

        // Check to see if FaultCode property is set
        internal bool IsSetFaultCode()
        {
            return this._faultCode != null;
        }

        /// <summary>
        /// Gets and sets the property IntervalEndTime. 
        /// <para>
        ///  Returns all labels with a start time earlier than the end time given. 
        /// </para>
        /// </summary>
        public DateTime? IntervalEndTime
        {
            get { return this._intervalEndTime; }
            set { this._intervalEndTime = value; }
        }

        // Check to see if IntervalEndTime property is set
        internal bool IsSetIntervalEndTime()
        {
            return this._intervalEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalStartTime. 
        /// <para>
        ///  Returns all the labels with a end time equal to or later than the start time given.
        /// 
        /// </para>
        /// </summary>
        public DateTime? IntervalStartTime
        {
            get { return this._intervalStartTime; }
            set { this._intervalStartTime = value; }
        }

        // Check to see if IntervalStartTime property is set
        internal bool IsSetIntervalStartTime()
        {
            return this._intervalStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  Returns the name of the label group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string LabelGroupName
        {
            get { return this._labelGroupName; }
            set { this._labelGroupName = value; }
        }

        // Check to see if LabelGroupName property is set
        internal bool IsSetLabelGroupName()
        {
            return this._labelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of labels to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of label groups.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}