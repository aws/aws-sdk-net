/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Extensions.CognitoAuthentication
{
    public class CognitoConstants
    {
        // Challenge Parameters
        public static string ChlgParamSrpA = "SRP_A";
        public static string ChlgParamSrpB = "SRP_B";
        public static string ChlgParamSecretHash = "SECRET_HASH";
        public static string ChlgParamUsername = "USERNAME";
        public static string ChlgParamChallengeName = "CHALLENGE_NAME";
        public static string ChlgParamSalt = "SALT";
        public static string ChlgParamSecretBlock = "SECRET_BLOCK";
        public static string ChlgParamUserIDSrp = "USER_ID_FOR_SRP";
        public static string ChlgParamRefreshToken = "REFRESH_TOKEN";

        public static string ChlgParamPassSecretBlock = "PASSWORD_CLAIM_SECRET_BLOCK";
        public static string ChlgParamPassSignature = "PASSWORD_CLAIM_SIGNATURE";
        public static string ChlgParamTimestamp = "TIMESTAMP";
        public static string ChlgParamDeliveryDest = "CODE_DELIVERY_DESTINATION";
        public static string ChlgParamDeliveryMed = "CODE_DELIVERY_DELIVERY_MEDIUM";

        public static string ChlgParamSmsMfaCode = "SMS_MFA_CODE";
        public static string ChlgParamDeviceKey = "DEVICE_KEY";

        public static string ChlgParamUserAttrs = "userAttributes";
        public static string ChlgParamRequiredAttrs = "requiredAttributes";
        public static string ChlgParamUserAttrPrefix = "userAttributes.";
        public static string ChlgParamNewPassword = "NEW_PASSWORD";
        public static string ChlgParamPassword = "PASSWORD";

        // User Attributes
        public static string UserAttrEmail = "email";
        public static string UserAttrPhoneNumber = "phone_number";

        // Device Attributes
        public static string DeviceAttrName = "device_name";
        public static string DeviceAttrRemembered = "remembered";
        public static string DeviceAttrNotRemembered = "not_remembered";

        public static string DeviceChlgParamSalt = "salt";
        public static string DeviceChlgParamVerifier = "verifier";
    }
}
