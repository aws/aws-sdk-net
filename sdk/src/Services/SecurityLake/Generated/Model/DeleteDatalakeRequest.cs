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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDatalake operation.
    /// When you delete Amazon Security Lake from your account, Security Lake is disabled
    /// in all Amazon Web Services Regions. Also, this API automatically takes steps to remove
    /// the account from Security Lake . 
    /// 
    ///  
    /// <para>
    /// This operation disables security data collection from sources, deletes data stored,
    /// and stops making data accessible to subscribers. Security Lake also deletes all the
    /// existing settings and resources that it stores or maintains for your Amazon Web Services
    /// account in the current Region, including security log and event data. The <code>DeleteDatalake</code>
    /// operation does not delete the Amazon S3 bucket, which is owned by your Amazon Web
    /// Services account. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/disable-security-lake.html">Amazon
    /// Security Lake User Guide</a>.
    /// </para>
    /// </summary>
    public partial class DeleteDatalakeRequest : AmazonSecurityLakeRequest
    {

    }
}