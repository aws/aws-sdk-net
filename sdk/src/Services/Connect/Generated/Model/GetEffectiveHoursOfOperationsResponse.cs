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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetEffectiveHoursOfOperations operation.
    /// </summary>
    public partial class GetEffectiveHoursOfOperationsResponse : AmazonWebServiceResponse
    {
        private List<EffectiveHoursOfOperations> _effectiveHoursOfOperationList = AWSConfigs.InitializeCollections ? new List<EffectiveHoursOfOperations>() : null;
        private List<EffectiveOverrideHours> _effectiveOverrideHoursList = AWSConfigs.InitializeCollections ? new List<EffectiveOverrideHours>() : null;
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property EffectiveHoursOfOperationList. 
        /// <para>
        /// Information about the effective hours of operations.
        /// </para>
        /// </summary>
        public List<EffectiveHoursOfOperations> EffectiveHoursOfOperationList
        {
            get { return this._effectiveHoursOfOperationList; }
            set { this._effectiveHoursOfOperationList = value; }
        }

        // Check to see if EffectiveHoursOfOperationList property is set
        internal bool IsSetEffectiveHoursOfOperationList()
        {
            return this._effectiveHoursOfOperationList != null && (this._effectiveHoursOfOperationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EffectiveOverrideHoursList. 
        /// <para>
        /// Information about override configurations applied to the base hours of operation to
        /// calculate the effective hours.
        /// </para>
        ///  
        /// <para>
        /// For more information about how override types are applied, see <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/connect/latest/adminguide/hours-of-operation-overrides.html">Build
        /// your list of overrides</a> in the <i> Administrator Guide</i>.
        /// </para>
        /// </summary>
        public List<EffectiveOverrideHours> EffectiveOverrideHoursList
        {
            get { return this._effectiveOverrideHoursList; }
            set { this._effectiveOverrideHoursList = value; }
        }

        // Check to see if EffectiveOverrideHoursList property is set
        internal bool IsSetEffectiveOverrideHoursList()
        {
            return this._effectiveOverrideHoursList != null && (this._effectiveOverrideHoursList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone for the hours of operation.
        /// </para>
        /// </summary>
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

    }
}