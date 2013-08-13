/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAlarmHistory operation.
    /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
    /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
    /// two weeks, whether or not you delete the alarm. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarmHistory"/>
    public class DescribeAlarmHistoryRequest : AmazonWebServiceRequest
    {
        private string alarmName;
        private string historyItemType;
        private DateTime? startDate;
        private DateTime? endDate;
        private int? maxRecords;
        private string nextToken;

        /// <summary>
        /// The name of the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this.alarmName; }
            set { this.alarmName = value; }
        }

        /// <summary>
        /// Sets the AlarmName property
        /// </summary>
        /// <param name="alarmName">The value to set for the AlarmName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmHistoryRequest WithAlarmName(string alarmName)
        {
            this.alarmName = alarmName;
            return this;
        }
            

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this.alarmName != null;       
        }

        /// <summary>
        /// The type of alarm histories to retrieve.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ConfigurationUpdate, StateUpdate, Action</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HistoryItemType
        {
            get { return this.historyItemType; }
            set { this.historyItemType = value; }
        }

        /// <summary>
        /// Sets the HistoryItemType property
        /// </summary>
        /// <param name="historyItemType">The value to set for the HistoryItemType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmHistoryRequest WithHistoryItemType(string historyItemType)
        {
            this.historyItemType = historyItemType;
            return this;
        }
            

        // Check to see if HistoryItemType property is set
        internal bool IsSetHistoryItemType()
        {
            return this.historyItemType != null;       
        }

        /// <summary>
        /// The starting date to retrieve alarm history.
        ///  
        /// </summary>
        public DateTime StartDate
        {
            get { return this.startDate ?? default(DateTime); }
            set { this.startDate = value; }
        }

        /// <summary>
        /// Sets the StartDate property
        /// </summary>
        /// <param name="startDate">The value to set for the StartDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmHistoryRequest WithStartDate(DateTime startDate)
        {
            this.startDate = startDate;
            return this;
        }
            

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this.startDate.HasValue;       
        }

        /// <summary>
        /// The ending date to retrieve alarm history.
        ///  
        /// </summary>
        public DateTime EndDate
        {
            get { return this.endDate ?? default(DateTime); }
            set { this.endDate = value; }
        }

        /// <summary>
        /// Sets the EndDate property
        /// </summary>
        /// <param name="endDate">The value to set for the EndDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmHistoryRequest WithEndDate(DateTime endDate)
        {
            this.endDate = endDate;
            return this;
        }
            

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this.endDate.HasValue;       
        }

        /// <summary>
        /// The maximum number of alarm history records to retrieve.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmHistoryRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }

        /// <summary>
        /// The token returned by a previous call to indicate that there is more data available.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAlarmHistoryRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
    }
}
    
