/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGraph operation.
    /// Creates a new behavior graph for the calling account, and sets that account as the
    /// master account. This operation is called by the account that is enabling Detective.
    /// 
    ///  
    /// <para>
    /// Before you try to enable Detective, make sure that your account has been enrolled
    /// in Amazon GuardDuty for at least 48 hours. If you do not meet this requirement, you
    /// cannot enable Detective. If you do meet the GuardDuty prerequisite, then when you
    /// make the request to enable Detective, it checks whether your data volume is within
    /// the Detective quota. If it exceeds the quota, then you cannot enable Detective. 
    /// </para>
    ///  
    /// <para>
    /// The operation also enables Detective for the calling account in the currently selected
    /// Region. It returns the ARN of the new behavior graph.
    /// </para>
    ///  
    /// <para>
    ///  <code>CreateGraph</code> triggers a process to create the corresponding data tables
    /// for the new behavior graph.
    /// </para>
    ///  
    /// <para>
    /// An account can only be the master account for one behavior graph within a Region.
    /// If the same account calls <code>CreateGraph</code> with the same master account, it
    /// always returns the same behavior graph ARN. It does not create a new behavior graph.
    /// </para>
    /// </summary>
    public partial class CreateGraphRequest : AmazonDetectiveRequest
    {

    }
}