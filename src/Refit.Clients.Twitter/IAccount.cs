﻿namespace Refit.Clients.Twitter
{
    using System.Threading.Tasks;
    using Refit;
    using Refit.Clients.Twitter.Models;
    using Refit.Clients.Twitter.Models.QueryParams;

    [Headers("Authorization: OAuth")]
    public interface IAccount
    {
        [Get("/account/settings.json")]
        Task<AccountSettings> Settings();

        [Get("/account/verify_credentials.json")]
        Task<User> VerifyCredentials();

        [Get("/users/profile_banner.json")]
        Task<ProfileBanners> ProfileBanner([Query]IDOrScreenNameQueryParams queryParams);

        [Post("/account/remove_profile_banner.json")]
        Task RemoveProfileBanner();

        [Post("/account/settings.json")]
        Task<User> UpdateSettings([Query]AccountSettings settings);

        [Post("/account/update_profile.json")]
        Task<User> UpdateProfile([Query]ProfileAccountSettings profile);

        [Post("/account/update_profile_banner.json")]
        Task UpdateProfileBanner([Query]ProfileBannerQueryParams queryParams, [Body(BodySerializationMethod.UrlEncoded)]string banner);

        [Post("/account/update_profile_image.json")]
        Task UpdateProfileImage();
    }
}
