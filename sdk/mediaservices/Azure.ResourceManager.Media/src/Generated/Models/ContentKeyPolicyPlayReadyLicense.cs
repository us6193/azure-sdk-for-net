// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The PlayReady license. </summary>
    public partial class ContentKeyPolicyPlayReadyLicense
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadyLicense"/>. </summary>
        /// <param name="allowTestDevices"> A flag indicating whether test devices can use the license. </param>
        /// <param name="licenseType"> The license type. </param>
        /// <param name="contentKeyLocation">
        /// The content key location.
        /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
        /// </param>
        /// <param name="contentType"> The PlayReady content type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyLocation"/> is null. </exception>
        public ContentKeyPolicyPlayReadyLicense(bool allowTestDevices, ContentKeyPolicyPlayReadyLicenseType licenseType, ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation, ContentKeyPolicyPlayReadyContentType contentType)
        {
            Argument.AssertNotNull(contentKeyLocation, nameof(contentKeyLocation));

            AllowTestDevices = allowTestDevices;
            LicenseType = licenseType;
            ContentKeyLocation = contentKeyLocation;
            ContentType = contentType;
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadyLicense"/>. </summary>
        /// <param name="allowTestDevices"> A flag indicating whether test devices can use the license. </param>
        /// <param name="securityLevel"> The security level. </param>
        /// <param name="beginOn"> The begin date of license. </param>
        /// <param name="expireOn"> The expiration date of license. </param>
        /// <param name="relativeBeginDate"> The relative begin date of license. </param>
        /// <param name="relativeExpirationDate"> The relative expiration date of license. </param>
        /// <param name="gracePeriod"> The grace period of license. </param>
        /// <param name="playRight"> The license PlayRight. </param>
        /// <param name="licenseType"> The license type. </param>
        /// <param name="contentKeyLocation">
        /// The content key location.
        /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
        /// </param>
        /// <param name="contentType"> The PlayReady content type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentKeyPolicyPlayReadyLicense(bool allowTestDevices, PlayReadySecurityLevel? securityLevel, DateTimeOffset? beginOn, DateTimeOffset? expireOn, TimeSpan? relativeBeginDate, TimeSpan? relativeExpirationDate, TimeSpan? gracePeriod, ContentKeyPolicyPlayReadyPlayRight playRight, ContentKeyPolicyPlayReadyLicenseType licenseType, ContentKeyPolicyPlayReadyContentKeyLocation contentKeyLocation, ContentKeyPolicyPlayReadyContentType contentType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowTestDevices = allowTestDevices;
            SecurityLevel = securityLevel;
            BeginOn = beginOn;
            ExpireOn = expireOn;
            RelativeBeginDate = relativeBeginDate;
            RelativeExpirationDate = relativeExpirationDate;
            GracePeriod = gracePeriod;
            PlayRight = playRight;
            LicenseType = licenseType;
            ContentKeyLocation = contentKeyLocation;
            ContentType = contentType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadyLicense"/> for deserialization. </summary>
        internal ContentKeyPolicyPlayReadyLicense()
        {
        }

        /// <summary> A flag indicating whether test devices can use the license. </summary>
        public bool AllowTestDevices { get; set; }
        /// <summary> The security level. </summary>
        public PlayReadySecurityLevel? SecurityLevel { get; set; }
        /// <summary> The begin date of license. </summary>
        public DateTimeOffset? BeginOn { get; set; }
        /// <summary> The expiration date of license. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The relative begin date of license. </summary>
        public TimeSpan? RelativeBeginDate { get; set; }
        /// <summary> The relative expiration date of license. </summary>
        public TimeSpan? RelativeExpirationDate { get; set; }
        /// <summary> The grace period of license. </summary>
        public TimeSpan? GracePeriod { get; set; }
        /// <summary> The license PlayRight. </summary>
        public ContentKeyPolicyPlayReadyPlayRight PlayRight { get; set; }
        /// <summary> The license type. </summary>
        public ContentKeyPolicyPlayReadyLicenseType LicenseType { get; set; }
        /// <summary>
        /// The content key location.
        /// Please note <see cref="ContentKeyPolicyPlayReadyContentKeyLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromHeader"/> and <see cref="ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier"/>.
        /// </summary>
        public ContentKeyPolicyPlayReadyContentKeyLocation ContentKeyLocation { get; set; }
        /// <summary> The PlayReady content type. </summary>
        public ContentKeyPolicyPlayReadyContentType ContentType { get; set; }
    }
}
