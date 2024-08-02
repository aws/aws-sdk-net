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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTextMessageSpendLimitOverride operation.
    /// Deletes an account-level monthly spending limit override for sending text messages.
    /// Deleting a spend limit override will set the <c>EnforcedLimit</c> to equal the <c>MaxLimit</c>,
    /// which is controlled by Amazon Web Services. For more information on spend limits (quotas)
    /// see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
    /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
    /// </summary>
    public partial class DeleteTextMessageSpendLimitOverrideRequest : AmazonPinpointSMSVoiceV2Request
    {

    }
}