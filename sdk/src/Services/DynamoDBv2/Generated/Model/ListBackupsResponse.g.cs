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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the ListBackups operation.
    /// </summary>
    public partial class ListBackupsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BackupSummaries. 
        /// <para>
        /// List of <c>BackupSummary</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BackupSummary> BackupSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<BackupSummary>() : null;

        /// <summary>
        /// Checks to see if the BackupSummaries property is set.
        /// </summary>
        internal bool IsSetBackupSummaries() => this.BackupSummaries != null && (this.BackupSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastEvaluatedBackupArn. 
        /// <para>
        ///  The ARN of the backup last evaluated when the current page of results was returned,
        /// inclusive of the current page of results. This value may be specified as the <c>ExclusiveStartBackupArn</c>
        /// of a new <c>ListBackups</c> operation in order to fetch the next page of results.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If <c>LastEvaluatedBackupArn</c> is empty, then the last page of results has been
        /// processed and there are no more results to be retrieved. 
        /// </para>
        ///  
        /// <para>
        ///  If <c>LastEvaluatedBackupArn</c> is not empty, this may or may not indicate that
        /// there is more data to be returned. All results are guaranteed to have been returned
        /// if and only if no value for <c>LastEvaluatedBackupArn</c> is returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string LastEvaluatedBackupArn { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedBackupArn property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedBackupArn() => this.LastEvaluatedBackupArn != null;
    }
}
