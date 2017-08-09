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

using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;



namespace Amazon.Extensions.CognitoAuthentication
{
    public partial class CognitoDevice
    {
        /// <summary>
        /// The device key associated with the device. DeviceKey can only be configured 
        /// through the constructor and the GetDevice method.
        /// </summary>
        public string DeviceKey { get; private set; }

        /// <summary>
        /// The device attributes associated with the device. DeviceAttributes can only be
        /// configured through the constructor and the GetDevice method.
        /// </summary>
        public Dictionary<string, string> DeviceAttributes { get; private set; }

        /// <summary>
        /// The creation time for the device. CreateDate can only be configured 
        /// through the constructor and once set cannot be changed.
        /// </summary>
        public DateTime CreateDate { get; private set; }

        /// <summary>
        /// The last modified time for the device. LastModified can only be configured 
        /// through the constructor and the GetDevice method.
        /// </summary>
        public DateTime LastModified { get; private set; }

        /// <summary>
        /// The last authenticated time for the device. LastAuthenticated can only be configured 
        /// through the constructor and the GetDevice method.
        /// </summary>
        public DateTime LastAuthenticated { get; private set; }

        /// <summary>
        /// The user associated with the device. User can only be configured 
        /// through the constructor, and once set it cannot be changed.
        /// </summary>
        public CognitoUser User { get; private set; }

        /// <summary>
        /// The group device key of the associated device
        /// </summary>
        public string GroupDeviceKey { get; set; }

        /// <summary>
        /// The device secret of the associated device
        /// </summary>
        public string DeviceSecret { get; set; }

        /// <summary>
        /// Creates an instance of CognitoDevice
        /// </summary>
        /// <param name="deviceKey">The device key for the device</param>
        /// <param name="deviceAttributes">The attributes for the device</param>
        /// <param name="createDate">The creation date for the device</param>
        /// <param name="lastModified">The last modified date for the device</param>
        /// <param name="lastAuthenticated">The last authenticated date for the device</param>
        /// <param name="user">The CognitoUser associated with the device</param>
        public CognitoDevice(string deviceKey,
                             IDictionary<string, string> deviceAttributes,
                             DateTime createDate,
                             DateTime lastModified,
                             DateTime lastAuthenticated,
                             CognitoUser user)
        {
            if (deviceKey == null)
            {
                throw new ArgumentNullException("deviceKey", "deviceKey cannot be null.");
            }

            if(deviceAttributes == null)
            {
                throw new ArgumentNullException("deviceAttributes", "deviceAttributes cannot be null.");

            }

            this.DeviceKey = deviceKey;
            this.DeviceAttributes = new Dictionary<string,string>(deviceAttributes);
            this.CreateDate = createDate;
            this.LastModified = lastModified;
            this.LastAuthenticated = lastAuthenticated;
            this.User = user;
        }

        /// <summary>
        /// Creates an instance of CognitoDevice
        /// </summary>
        /// <param name="device">A DeviceType object to create the CognitoDevice from</param>
        /// <param name="user">The CognitoUser associated with the device</param>
        public CognitoDevice(DeviceType device, CognitoUser user)
        {
            if (device == null)
            {
                throw new ArgumentNullException("device", "Device cannot be null.");
            }

            this.DeviceKey = device.DeviceKey;
            this.CreateDate = device.DeviceCreateDate;
            this.LastModified = device.DeviceLastModifiedDate;
            this.LastAuthenticated = device.DeviceLastAuthenticatedDate;
            this.User = user;
            this.DeviceAttributes = CreateDictionaryFromAttributeList(device.DeviceAttributes);
        }

        /// <summary>
        /// Gets a device attrbute based on the attribute name
        /// </summary>
        /// <param name="attributeName">The name of the desired attribute</param>
        /// <returns>Returns a device attrbute based on the attribute name</returns>
        public string GetDeviceAttribute(string attributeName)
        {
            string attributeValue = null;

            if (DeviceAttributes.ContainsKey(attributeName))
            {
                attributeValue = DeviceAttributes[attributeName];
            }

            return attributeValue;
        }

        /// <summary>
        /// Gets the name of the device
        /// </summary>
        /// <returns>Returns the name of the device</returns>
        public string GetDeviceName()
        {
            return GetDeviceAttribute(CognitoConstants.DeviceAttrName);
        }

        /// <summary>
        /// Gets the device from the Cognito service using the device key and user's access 
        /// token using an asynchronous call
        /// </summary>
        public async Task GetDeviceAsync()
        {
            GetDeviceRequest getDeviceRequest = CreateGetDeviceRequest();

            GetDeviceResponse getDeviceResponse =
                await User.Provider.GetDeviceAsync(getDeviceRequest).ConfigureAwait(false);

            UpdateThisDevice(getDeviceResponse.Device);
        }

        /// <summary>
        /// Forgets the device associated with the CognitoDevice's device key using
        /// an asynchronous call
        /// </summary>
        public Task ForgetDeviceAsync()
        {
            ForgetDeviceRequest forgetDeviceRequest = CreateForgetDeviceRequest();
            return User.Provider.ForgetDeviceAsync(forgetDeviceRequest);
        }

        /// <summary>
        /// Updates the device status to be remembered using an asynchronous call
        /// </summary>
        public Task RememberThisDeviceAsync()
        {
            UpdateDeviceStatusRequest updateRequest =
                CreateUpdateDeviceStatusRequest(new DeviceRememberedStatusType(CognitoConstants.DeviceAttrRemembered));

            return User.Provider.UpdateDeviceStatusAsync(updateRequest);
        }

        /// <summary>
        /// Updates the device status to not be remembered using an asynchronous call
        /// </summary>
        public Task DoNotRememberThisDeviceAsync()
        {
            UpdateDeviceStatusRequest updateRequest =
                    CreateUpdateDeviceStatusRequest(new DeviceRememberedStatusType(CognitoConstants.DeviceAttrNotRemembered));

            return User.Provider.UpdateDeviceStatusAsync(updateRequest);
        }

        private GetDeviceRequest CreateGetDeviceRequest()
        {
            if (User.SessionTokens == null || !User.SessionTokens.IsValid())
            {
                throw new NotAuthorizedException("User is not authorized.");
            }

            GetDeviceRequest getDeviceRequest = new GetDeviceRequest()
            {
                AccessToken = User.SessionTokens.AccessToken,
                DeviceKey = DeviceKey
            };

            return getDeviceRequest;
        }        

        /// <summary>
        /// Internal method to update the properties of the current CognitoDevice object
        /// </summary>
        /// <param name="device"></param>
        private void UpdateThisDevice(DeviceType device)
        {
            if (device == null)
            {
                throw new InternalErrorException("Service returned null object, this device was not updated.");
            }

            if (!string.Equals(device.DeviceKey, this.DeviceKey))
            {
                throw new InternalErrorException("Device keys don't match, this device was not updated.");
            }

            DeviceAttributes = CreateDictionaryFromAttributeList(device.DeviceAttributes);
            LastModified = device.DeviceLastModifiedDate;
            LastAuthenticated = device.DeviceLastAuthenticatedDate;
        }

        private ForgetDeviceRequest CreateForgetDeviceRequest()
        {
            if (User.SessionTokens == null || !User.SessionTokens.IsValid())
            {
                throw new NotAuthorizedException("User is not authorized.");
            }

            ForgetDeviceRequest forgetDeviceRequest = new ForgetDeviceRequest()
            {
                AccessToken = User.SessionTokens.AccessToken,
                DeviceKey = DeviceKey
            };

            return forgetDeviceRequest;
        }

        private UpdateDeviceStatusRequest CreateUpdateDeviceStatusRequest(DeviceRememberedStatusType deviceRememberedStatus)
        {
            if (User.SessionTokens == null || !User.SessionTokens.IsValid())
            {
                throw new NotAuthorizedException("User is not authorized.");
            }

            UpdateDeviceStatusRequest updateDeviceStatusRequest = new UpdateDeviceStatusRequest()
            {
                AccessToken = User.SessionTokens.AccessToken,
                DeviceKey = DeviceKey,
                DeviceRememberedStatus = deviceRememberedStatus
            };

            return updateDeviceStatusRequest;
        }

        /// <summary>
        /// Internal method for creating a dictionary of attrbutes from a list of AttributeType objects
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        private Dictionary<string,string> CreateDictionaryFromAttributeList(IList<AttributeType> attributes)
        {
            Dictionary<string, string> attributesDict = new Dictionary<string, string>();

            foreach(AttributeType attribute in attributes)
            {
                attributesDict.Add(attribute.Name, attribute.Value);
            }

            return attributesDict;
        }
    }
}
